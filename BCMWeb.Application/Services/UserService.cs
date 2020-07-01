using BCMWeb.Application.Exceptions;
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
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly PaginationOptions _paginationOptions;

        public UserService(IUnitOfWork unitOfWork, IOptions<PaginationOptions> paginationOptions)
        {
            _unitOfWork = unitOfWork;
            _paginationOptions = paginationOptions.Value;
        }

        public async Task<long> Add(User entity)
        {
            var _users = _unitOfWork.UserRepository.GetAll();
            var _user = _users.FirstOrDefault(x => x.Email == entity.Email);

            if (_user != null)
            {
                throw new BusinessException("Email ya existe");
            }

            entity.FirstTime = true;
            entity.UserStateId = 1;
            entity.UserStateDateChange = DateTime.UtcNow;

            await _unitOfWork.UserRepository.Add(entity);
            await _unitOfWork.SaveChangesAsync();

            return entity.UserId;
        }

        public Task<bool> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> Get(object[] keyValues)
        {
            return await _unitOfWork.UserRepository.Get(keyValues);
        }

        public PagedList<User> GetAll(PaginationFilter filters)
        {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            var _data = _unitOfWork.UserRepository.GetAll();

            var _dataPaged = PagedList<User>.Create(_data, filters.PageNumber, filters.PageSize);

            return _dataPaged;
        }

        public User Login(UserLogin userLogin)
        {
            return _unitOfWork.UserRepository.Login(userLogin);
        }

        public async Task<bool> Update(User entity)
        {
            _unitOfWork.UserRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
