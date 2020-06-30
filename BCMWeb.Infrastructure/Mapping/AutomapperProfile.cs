using AutoMapper;
using BCMWeb.Core.DTOs;
using BCMWeb.Core.Entities;

namespace BCMWeb.Infrastructure.Mapping
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Company, CompanyDto>();
            CreateMap<CompanyDto, Company>();
        }
    }
}
