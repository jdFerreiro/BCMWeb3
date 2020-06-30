using AutoMapper;
using BCMWeb.API.Responses;
using BCMWeb.Application.Interfaces;
using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.DTOs;
using BCMWeb.Core.Entities;
using BCMWeb.Core.QueryFilters;
using BCMWeb.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace BCMWeb.API.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;

        public UserController(IUserService userService, IMapper mapper, IUriService uriService)
        {
            _userService = userService;
            _mapper = mapper;
            _uriService = uriService;
        }

        [HttpGet(Name = nameof(GetUsers))]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(APIResponse<IEnumerable<UserDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(APIResponse<IEnumerable<UserDto>>))]
        public IActionResult GetUsers([FromQuery] PaginationFilter filters)
        {
            var result = _userService.GetAll(filters);
            var data = _mapper.Map<IEnumerable<UserDto>>(result);

            var _metadata = new Metadata
            {
                TotalRows = result.TotalRows,
                TotalPages = result.TotalPages,
                PageSize = result.PageSize,
                CurrentPage = result.CurrentPage,
                HasNextPage = result.HasNextPage,
                HasPreviousPage = result.HasPreviousPage,
                NextPageUrl = result.HasNextPage ? _uriService.GetPaginationUri(new PaginationFilter
                {
                    PageNumber = result.CurrentPage,
                    PageSize = result.PageSize
                }, Url.RouteUrl(nameof(GetUsers))).ToString() : null,
                PreviousPageUrl = result.HasNextPage ? _uriService.GetPaginationUri(new PaginationFilter
                {
                    PageNumber = result.CurrentPage,
                    PageSize = result.PageSize
                }, Url.RouteUrl(nameof(GetUsers))).ToString() : null


            };

            var response = new APIResponse<IEnumerable<UserDto>>(data)
            {
                Meta = _metadata
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(APIResponse<UserDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(APIResponse<UserDto>))]
        public async Task<IActionResult> GeUsertById(long id)
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
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(long))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(long))]
        public async Task<IActionResult> AddUser(UserDto inputObject)
        {
            var _user = _mapper.Map<User>(inputObject);
            var _result = await _userService.Add(_user);
            var _response = new APIResponse<long>(_result);
            return Ok(_response);
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(bool))]
        public async Task<IActionResult> UpdateUser(UserDto inputObject)
        {
            var _user = _mapper.Map<User>(inputObject);
            var _result = await _userService.Update(_user);
            var _response = new APIResponse<bool>(_result);
            return Ok(_response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteUser(long id)
        {
            var _result = await _userService.Delete(id);
            var _response = new APIResponse<bool>(_result);
            return Ok(_response);
        }
    }
}
