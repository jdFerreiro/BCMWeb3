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
    public class SeveridadRiesgoRepository : ISeveridadRiesgoRepository
    {
        private readonly IConfiguration _configuration;

        public SeveridadRiesgoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(SeveridadRiesgo entity)
        {
            var sql = "INSERT INTO tblSeveridadRiesgo (IdEmpresa, IdSeveridad, Nombre) VALUES(@IdEmpresa, @IdSeveridad, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, short idseveridad)
        {
            var sql = "DELETE FROM tblSeveridadRiesgo WHERE IdEmpresa = @idempresa AND IdSeveridad = @idseveridad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdSeveridad = idseveridad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SeveridadRiesgo> Get(long idempresa, short idseveridad)
        {
            var sql = "SELECT IdEmpresa, IdSeveridad, Nombre FROM tblSeveridadRiesgo  WHERE IdEmpresa = @idempresa AND IdSeveridad = @idseveridad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<SeveridadRiesgo>(sql, new { IdEmpresa = idempresa, IdSeveridad = idseveridad });
                SeveridadRiesgo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<SeveridadRiesgo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<SeveridadRiesgo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdSeveridad, Nombre FROM tblSeveridadRiesgo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<SeveridadRiesgo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(SeveridadRiesgo entity)
        {
            var sql = "UPDATE tblSeveridadRiesgo SET IdEmpresa = @idempresa, IdSeveridad = @idseveridad, Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdSeveridad = @idseveridad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdSeveridad = entity.IdSeveridad });
                return _affectedRows;
            }
        }
    }
}
