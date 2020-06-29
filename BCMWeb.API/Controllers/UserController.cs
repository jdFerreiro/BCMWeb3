using AutoMapper;
using BCMWeb.API.Responses;
using BCMWeb.Application.Interfaces;
using BCMWeb.Core.DTOs;
using BCMWeb.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCMWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var result = _userService.GetAll();
            var data = _mapper.Map<IEnumerable<UserDto>>(result);
            var response = new APIResponse<IEnumerable<UserDto>>(data);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(long id)
        {
            object[] _keyValues = new object[]
            {
                id
            };
            var result = await _userService.Get(_keyValues);
            var data = _mapper.Map<UserDto>(result);
            var response = new APIResponse<UserDto>(data);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserDto usuario)
        {
            var _user = _mapper.Map<User>(usuario);
            var _userId = await _userService.Add(_user);
            var _userDto = _mapper.Map<UserDto>(_user);
            var response = new APIResponse<UserDto>(_userDto);
            return Ok(_userId);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserDto usuario)
        {
            var _user = _mapper.Map<User>(usuario);
            await _userService.Update(_user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _userService.Delete(id);
            return Ok();
        }
    }
}
