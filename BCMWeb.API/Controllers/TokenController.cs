using AutoMapper;
using BCMWeb.API.Responses;
using BCMWeb.Application.Interfaces;
using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace BCMWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public TokenController(IUserService userService, IMapper mapper, IConfiguration configuration)
        {
            _userService = userService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(APIResponse<UserDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(APIResponse<UserDto>))]
        public IActionResult Authentication(UserLogin login)
        {
            UserDto user = GetUserData(login);
            if (user.UserId > 0)
            {
                var token = GenerateToken(user);
                return Ok(new { token });
            }

            return NotFound();
        }

        private UserDto GetUserData(UserLogin login)
        {
            var result = _userService.Login(login);
            var data = _mapper.Map<UserDto>(result);
            return data;
        }

        private string GenerateToken(UserDto user)
        {
            var _symetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:secretKey"]));
            var _signingCredentials = new SigningCredentials(_symetricSecurityKey, SecurityAlgorithms.HmacSha512);
            var _header = new JwtHeader(_signingCredentials);

            // Claims
            var _claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Sid, user.UserId.ToString()),
            };

            //Payload
            var _payLoad = new JwtPayload
            (
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                _claims,
                DateTime.Now,
                DateTime.UtcNow.AddMinutes(2)
            );

            var _token = new JwtSecurityToken(_header, _payLoad);
            return new JwtSecurityTokenHandler().WriteToken(_token);
        }
    }
}
