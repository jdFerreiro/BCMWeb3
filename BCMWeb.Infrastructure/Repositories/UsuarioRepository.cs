using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using BCMWeb.Infrastructure.Utilities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private Encriptador _encriptar = new Encriptador();

        private readonly IConfiguration _configuration;

        public UsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<long> Add(Usuario entity)
        {
            entity.FechaEstado = DateTime.Now;
            entity.EstadoUsuario = Core.Enums.UsuarioEstado.Activo;
            entity.ClaveUsuario = _encriptar.Encriptar(entity.ClaveUsuario, Encriptador.HasAlgorimt.SHA1, Encriptador.Keysize.KS256);

            var sql = @"INSERT INTO tblUsuario (CodigoUsuario, ClaveUsuario, Nombre, EstadoUsuario, FechaEstado, PrimeraVez, Email)
                        VALUES(@Codigo, @Passw, @Nombre, @Estado, @FechaEstado, 1, @Codigo);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long id)
        {
            var sql = @"UPDATE tblUsuario SET EstadoUsuario = 4, FechaEstado = GETDATE() WHERE IdUsuario = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return _affectedRows;
            }
        }
        public async Task<Usuario> Get(long id)
        {
            var sql = @"SELECT IdUsuario, CodigoUsuario, ClaveUsuario, Nombre, EstadoUsuario, FechaEstado, FechaUltimaConexion, PrimeraVez, Email
                        FROM dbo.tblUsuario WHERE IdUsuario = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Usuario>(sql, new { Id = id });
                Usuario _usuario = _result.FirstOrDefault();
                if (_usuario != null)
                {
                    _usuario.ClaveUsuario = _encriptar.Desencriptar(_usuario.ClaveUsuario, Encriptador.HasAlgorimt.SHA1, Encriptador.Keysize.KS256);
                }

                return _usuario;
            }

        }
        public async Task<IEnumerable<Usuario>> GetAll()
        {
            var sql = @"SELECT IdUsuario, CodigoUsuario, ClaveUsuario, Nombre, EstadoUsuario, FechaEstado, FechaUltimaConexion, PrimeraVez, Email
                        FROM dbo.tblUsuario WHERE EstadoUsuario != 4;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Usuario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Usuario entity)
        {
            entity.ClaveUsuario = _encriptar.Encriptar(entity.ClaveUsuario, Encriptador.HasAlgorimt.SHA1, Encriptador.Keysize.KS256);

            var sql = @"UPDATE tblUsuario SET ClaveUsuario = @Passw, Nombre = @Nombre, Email = @Email WHERE IdUsuario = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = entity.IdUsuario });
                return _affectedRows;
            }
        }
        public async Task<int> Login(string codigo, string password)
        {
            string _encPassword = _encriptar.Encriptar(password, Encriptador.HasAlgorimt.SHA1, Encriptador.Keysize.KS256);
            int _valid = 0;

            var sql = @"SELECT IdUsuario, CodigoUsuario, ClaveUsuario, Nombre, EstadoUsuario, FechaEstado, FechaUltimaConexion, PrimeraVez, Email
                        FROM dbo.tblUsuario WHERE CodigoUsuario = @Codigo AND ClaveUsuario = @Clave;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Usuario>(sql, new { Codigo = codigo, Clave = _encPassword });
                Usuario _usuario = _result.FirstOrDefault();
                if (_usuario != null)
                {
                    switch (_usuario.EstadoUsuario)
                    {
                        case Core.Enums.UsuarioEstado.Activo:
                            _valid = (int)_usuario.EstadoUsuario;
                            break;
                        case Core.Enums.UsuarioEstado.Bloqueado:
                            _valid = (int)_usuario.EstadoUsuario;
                            break;
                        case Core.Enums.UsuarioEstado.Eliminado:
                            _valid = (int)_usuario.EstadoUsuario;
                            break;
                        case Core.Enums.UsuarioEstado.Inactivo:
                            EmpresaRepository empresaRepository = new EmpresaRepository(_configuration);
                            AuditoriaRepository auditoriaRepository = new AuditoriaRepository(_configuration);
                            _usuario.Empresas = empresaRepository.GetEmpresasByUsuario(_usuario.IdUsuario).Result;
                            sql = @"UPDATE tblUsuario SET EstadoUsuario = 2, FechaEstado = GETDATE() WHERE IdUsuario = @Id;";
                            var _affectedRows = await connection.ExecuteAsync(sql, new { Id = _usuario.IdUsuario });
                            if (_affectedRows > 0) _valid = (int)Core.Enums.UsuarioEstado.Activo;
                            break;
                    }
                }
            }

            return _valid;
        }
        public async Task<long> LogOut(long id)
        {
            var sql = @"UPDATE tblUsuario SET EstadoUsuario = 1, FechaEstado = GETDATE() WHERE IdUsuario = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return _affectedRows;
            }
        }
        public async Task<long> Lock(long id)
        {
            var sql = @"UPDATE tblUsuario SET EstadoUsuario = 3, FechaEstado = GETDATE() WHERE IdUsuario = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return _affectedRows;
            }
        }
    }
}
