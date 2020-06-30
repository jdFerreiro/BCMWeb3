using AutoMapper;
using BCMWeb.API.Responses;
using BCMWeb.Application.Interfaces;
using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.DTOs;
using BCMWeb.Core.Entities;
using BCMWeb.Core.QueryFilters;
using BCMWeb.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace BCMWeb.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;

        public CompanyController(ICompanyService companyService, IMapper mapper, IUriService uriService)
        {
            _companyService = companyService;
            _mapper = mapper;
            _uriService = uriService;
        }

        /// <summary>
        /// Retrieve all companies
        /// </summary>
        /// <param name="filters">Filters to apply</param>
        /// <returns></returns>
        [HttpGet(Name = nameof(GetCompanies))]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(APIResponse<IEnumerable<CompanyDto>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(APIResponse<IEnumerable<CompanyDto>>))]
        public IActionResult GetCompanies([FromQuery] CompanyQueryFilter filters)
        {
            var result = _companyService.GetAll(filters);
            var data = _mapper.Map<IEnumerable<CompanyDto>>(result);

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
                }, Url.RouteUrl(nameof(GetCompanies))).ToString() : null,
                PreviousPageUrl = result.HasNextPage ? _uriService.GetPaginationUri(new PaginationFilter
                {
                    PageNumber = result.CurrentPage,
                    PageSize = result.PageSize
                }, Url.RouteUrl(nameof(GetCompanies))).ToString() : null
            };

            var response = new APIResponse<IEnumerable<CompanyDto>>(data)
            {
                Meta = _metadata
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(_metadata));
            return Ok(response);
        }

        /// <summary>
        /// Get company by Id
        /// </summary>
        /// <param name="id">Company Id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(APIResponse<UserDto>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(APIResponse<UserDto>))]
        public async Task<IActionResult> GetCompanyById(long id)
        {
            object[] _keyValues = new object[]
            {
                id
            };
            var result = await _companyService.Get(_keyValues);
            var data = _mapper.Map<UserDto>(result);
            var response = new APIResponse<UserDto>(data);
            return Ok(response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputObject"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(long))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(long))]
        public async Task<IActionResult> AddCompany(UserDto inputObject)
        {
            var _company = _mapper.Map<Company>(inputObject);
            var _result = await _companyService.Add(_company);
            var _response = new APIResponse<long>(_result);
            return Ok(_response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputObject"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(bool))]
        public async Task<IActionResult> UpdateCompany(UserDto inputObject)
        {
            var _company = _mapper.Map<Company>(inputObject);
            var _result = await _companyService.Update(_company);
            var _response = new APIResponse<bool>(_result);
            return Ok(_response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteCompany(long id)
        {
            var _result = await _companyService.Delete(id);
            var _response = new APIResponse<bool>(_result);
            return Ok(_response);
        }
    }
}
