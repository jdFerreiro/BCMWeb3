using BCMWeb.Application.Exceptions;
using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<long> Add(User entity)
        {
            var _users = GetAll();
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

        public Task Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> Get(object[] keyValues)
        {
            return await _unitOfWork.UserRepository.Get(keyValues);
        }

        public IEnumerable<User> GetAll()
        {
            return _unitOfWork.UserRepository.GetAll();
        }

        public async Task<bool> Update(User entity)
        {
            _unitOfWork.UserRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
