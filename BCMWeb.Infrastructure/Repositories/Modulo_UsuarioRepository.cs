using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class Modulo_UsuarioRepository : IModulo_UsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public Modulo_UsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Modulo_Usuario entity)
        {
            var sql = "INSERT INTO tblModulo_Usuario (IdEmpresa, IdModulo, IdUsuario, Actualizar, Eliminar) VALUES(@IdEmpresa, @IdModulo, @IdUsuario, @Actualizar, @Eliminar);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idmodulo, long idusuario)
        {
            var sql = "DELETE FROM tblModulo_Usuario WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdUsuario = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo, IdUsuario = idusuario });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Modulo_Usuario> Get(long idempresa, long idmodulo, long idusuario)
        {
            var sql = "SELECT IdEmpresa, IdModulo, IdUsuario, Actualizar, Eliminar FROM tblModulo_Usuario  WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdUsuario = @idusuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Modulo_Usuario>(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo, IdUsuario = idusuario });
                Modulo_Usuario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Modulo_Usuario> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Modulo_Usuario>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdModulo, IdUsuario, Actualizar, Eliminar FROM tblModulo_Usuario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Modulo_Usuario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Modulo_Usuario entity)
        {
            var sql = "UPDATE tblModulo_Usuario SET IdEmpresa = @idempresa, IdModulo = @idmodulo, IdUsuario = @idusuario, Actualizar = @actualizar, Eliminar = @eliminar WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdUsuario = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdModulo = entity.IdModulo, IdUsuario = entity.IdUsuario });
                return _affectedRows;
            }
        }

        Task<long> IModulo_UsuarioRepository.Delete(long idempresa, long idmodulo, long idusuario)
        {
            throw new System.NotImplementedException();
        }

        Task<Modulo_Usuario> IModulo_UsuarioRepository.Get(long idempresa, long idmodulo, long idusuario)
        {
            throw new System.NotImplementedException();
        }
    }
}
