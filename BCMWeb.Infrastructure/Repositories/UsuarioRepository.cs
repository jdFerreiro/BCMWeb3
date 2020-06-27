using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using BCMWeb.Core.Enums;
using BCMWeb.Infrastructure.Data;
using BCMWeb.Infrastructure.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Encriptador _encriptar = new Encriptador();
        private readonly BcmWebToolsContext _context;

        public UsuarioRepository(BcmWebToolsContext context)
        {
            _context = context;
        }

        public async Task<long> Add(User entity)
        {
            entity.UserStateDateChange = DateTime.UtcNow;
            entity.UserStateId = (short)UsuarioEstado.Activo;
            entity.UserPassw = _encriptar.Encriptar(entity.UserPassw, Encriptador.Keysize.KS256);

            _context.TblUsuario.Add(entity);
            var _affectedRows = await _context.SaveChangesAsync();
            return _affectedRows;
        }
        public async Task<long> Delete(long id)
        {
            _context.TblUsuario.Remove(_context.TblUsuario.FirstOrDefault(x => x.UserId == id));
            var _affectedRows = await _context.SaveChangesAsync();
            return _affectedRows;
        }
        public async Task<User> Get(long id)
        {

            User _usuario = await _context.TblUsuario.FirstOrDefaultAsync(x => x.UserId == id);
            if (_usuario != null)
            {
                _usuario.UserPassw = _encriptar.Desencriptar(_usuario.UserPassw, Encriptador.Keysize.KS256);
            }

            return _usuario;
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.TblUsuario.ToListAsync();
        }
        public async Task<long> Update(User entity)
        {
            entity.UserPassw = _encriptar.Encriptar(entity.UserPassw, Encriptador.Keysize.KS256);

            _context.TblUsuario.Update(entity);
            var _affectedRows = await _context.SaveChangesAsync();
            return _affectedRows;
        }
        public async Task<long> Login(string codigo, string password)
        {
            string _encPassword = _encriptar.Encriptar(password, Encriptador.Keysize.KS256);
            long _valid = 0;

            User _usuario = await _context.TblUsuario.FirstOrDefaultAsync(x => x.UserCode == codigo && x.UserPassw == _encPassword);
            if (_usuario != null)
            {
                switch ((UsuarioEstado)_usuario.UserStateId)
                {
                    case UsuarioEstado.Activo:
                        break;
                    case UsuarioEstado.Bloqueado:
                        break;
                    case UsuarioEstado.Eliminado:
                        break;
                    case UsuarioEstado.Inactivo:
                        _usuario.UserStateId = (short)UsuarioEstado.Activo;
                        _usuario.UserStateDateChange = DateTime.UtcNow;

                        var _affectedRows = await _context.SaveChangesAsync();
                        if (_affectedRows == 0) return _valid;

                        _valid = _usuario.UserId;
                        break;
                }
            }

            return _valid;
        }
        public async Task<long> LogOut(long id)
        {
            User _usuario = await _context.TblUsuario.FirstOrDefaultAsync(x => x.UserId == id);
            _usuario.UserStateId = (short)UsuarioEstado.Inactivo;
            _usuario.UserStateDateChange = DateTime.UtcNow;
            var _affectedRows = await _context.SaveChangesAsync();
            return _affectedRows;
        }
        public async Task<long> Lock(long id)
        {
            User _usuario = await _context.TblUsuario.FirstOrDefaultAsync(x => x.UserId == id);
            _usuario.UserStateId = (short)UsuarioEstado.Bloqueado;
            _usuario.UserStateDateChange = DateTime.UtcNow;
            var _affectedRows = await _context.SaveChangesAsync();
            return _affectedRows;
        }
    }
}
