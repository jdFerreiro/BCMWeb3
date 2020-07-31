using BCMWeb.Application.Enums;
using BCMWeb.Application.Interfaces;
using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.Entities;
using BCMWeb.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BcmWebToolsContext _context;
        protected readonly DbSet<User> _entities;

        public UserRepository(BcmWebToolsContext context)
        {
            _context = context;
            _entities = _context.Set<User>();
        }

        public async Task Add(User entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task Delete(object[] keyValues)
        {
            User entity = await Get(keyValues);
            _entities.Remove(entity);
        }

        public async Task<User> Get(object[] keyValues)
        {
            return await _entities.FindAsync(keyValues);
        }

        public IEnumerable<User> GetAll()
        {
            return _entities.ToListAsync().Result.AsEnumerable<User>();
        }

        public void Update(User entity)
        {
            _entities.Update(entity);
        }

        public async Task<bool> LogOut(long id)
        {
            bool _done = false;
            try
            {
                User _user = await _entities.FirstOrDefaultAsync(x => x.UserId == id);
                _user.UserStateId = (short)UserStateEnum.Inactivo;
                _user.UserStateDateChange = DateTime.UtcNow;
                _entities.Update(_user);
                _done = true;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                _done = false;
            }
            return _done;
        }

        public async Task<bool> Lock(long id)
        {
            bool _done = false;
            try
            {
                User _user = await _entities.FirstOrDefaultAsync(x => x.UserId == id);
                _user.UserStateId = (short)UserStateEnum.Bloqueado;
                _user.UserStateDateChange = DateTime.UtcNow;
                _entities.Update(_user);
                _done = true;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                _done = false;
            }
            return _done;
        }

        public async Task<User> Login(UserLogin login)
        {
            //string _encriptKey = encriptador.Encriptar(login.UserPassword, Encriptador.Keysize.KS256);
            //User _user = _entities.FirstOrDefault(x => x.UserCode == login.UserCode && x.UserPassw == _encriptKey);
            //return _user;

            return await _entities.FirstOrDefaultAsync(x => x.UserCode == login.UserCode && x.UserPassw == login.UserPassword);
        }

        public async Task<bool> Delete(long id)
        {
            bool _done = false;
            try
            {
                User _user = await _entities.FirstOrDefaultAsync(x => x.UserId == id);
                _user.UserStateId = (short)UserStateEnum.Eliminado;
                _user.UserStateDateChange = DateTime.UtcNow;
                _entities.Update(_user);
                _done = true;
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                _done = false;
            }
            return _done;
        }
    }
}
