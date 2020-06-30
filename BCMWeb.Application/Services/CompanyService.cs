using BCMWeb.Application.Interfaces;
using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.Entities;
using BCMWeb.Core.QueryFilters;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;

        public CompanyService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> paginationOptions)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = paginationOptions.Value;
        }
        public async Task<long> Add(Company entity)
        {
            //var _user = await _unitOfWork.UserRepository.Get(entity.userId);

            await _unitOfWork.CompanyRepository.Add(entity);
            await _unitOfWork.SaveChangesAsync();

            return entity.CompanyId;
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Company> Get(object[] keyValues)
        {
            return await _unitOfWork.CompanyRepository.Get(keyValues);
        }

        public PagedList<Company> GetAll(CompanyQueryFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            var _data = _unitOfWork.CompanyRepository.GetAll();

            if (filters.UserId != null)
            {
                _data = _data.Where(x => x.CompanyUsers.Any(p => p.UserId == filters.UserId));
            }
            if (filters.CountryId != null)
                _data = _data.Where(x => x.CountryId == filters.CountryId);
            if (filters.CountryStateId != null)
                _data = _data.Where(x => x.StateId == filters.CountryStateId);
            if (filters.CityId != null)
                _data = _data.Where(x => x.CityId == filters.CityId);

            var _dataPaged = PagedList<Company>.Create(_data, filters.PageNumber, filters.PageSize);

            return _dataPaged;
        }

        public async Task<bool> Update(Company entity)
        {
            _unitOfWork.CompanyRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
