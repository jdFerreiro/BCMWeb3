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
    public class Modulo_NivelUsuarioRepository : IModulo_NivelUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public Modulo_NivelUsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Modulo_NivelUsuario entity)
        {
            var sql = "INSERT INTO tblModulo_NivelUsuario (IdEmpresa, IdNivelUsuario, IdModulo, Actualizar, Eliminar) VALUES(@IdEmpresa, @IdNivelUsuario, @IdModulo, @Actualizar, @Eliminar);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idnivelusuario, long idmodulo)
        {
            var sql = "DELETE FROM tblModulo_NivelUsuario WHERE IdEmpresa = @idempresa AND IdNivelUsuario = @idnivelusuario AND IdModulo = @idmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdNivelUsuario = idnivelusuario, IdModulo = idmodulo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Modulo_NivelUsuario> Get(long idempresa, long idnivelusuario, long idmodulo)
        {
            var sql = "SELECT IdEmpresa, IdNivelUsuario, IdModulo, Actualizar, Eliminar FROM tblModulo_NivelUsuario  WHERE IdEmpresa = @idempresa AND IdNivelUsuario = @idnivelusuario AND IdModulo = @idmodulo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Modulo_NivelUsuario>(sql, new { IdEmpresa = idempresa, IdNivelUsuario = idnivelusuario, IdModulo = idmodulo });
                Modulo_NivelUsuario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Modulo_NivelUsuario> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Modulo_NivelUsuario>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdNivelUsuario, IdModulo, Actualizar, Eliminar FROM tblModulo_NivelUsuario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Modulo_NivelUsuario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Modulo_NivelUsuario entity)
        {
            var sql = "UPDATE tblModulo_NivelUsuario SET IdEmpresa = @idempresa, IdNivelUsuario = @idnivelusuario, IdModulo = @idmodulo, Actualizar = @actualizar, Eliminar = @eliminar WHERE IdEmpresa = @idempresa AND IdNivelUsuario = @idnivelusuario AND IdModulo = @idmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdNivelUsuario = entity.IdNivelUsuario, IdModulo = entity.IdModulo });
                return _affectedRows;
            }
        }
    }
}
