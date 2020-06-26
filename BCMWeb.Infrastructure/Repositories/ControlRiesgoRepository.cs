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
    public class ControlRiesgoRepository : IControlRiesgoRepository
    {
        private readonly IConfiguration _configuration;

        public ControlRiesgoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(ControlRiesgo entity)
        {
            var sql = "INSERT INTO tblControlRiesgo (IdEmpresa, IdControl, Nombre) VALUES(@IdEmpresa, @IdControl, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, short idcontrol)
        {
            var sql = "DELETE FROM tblControlRiesgo WHERE IdEmpresa = @idempresa AND IdControl = @idcontrol;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdControl = idcontrol });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ControlRiesgo> Get(long idempresa, short idcontrol)
        {
            var sql = "SELECT IdEmpresa, IdControl, Nombre FROM tblControlRiesgo  WHERE IdEmpresa = @idempresa AND IdControl = @idcontrol;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<ControlRiesgo>(sql, new { IdEmpresa = idempresa, IdControl = idcontrol });
                ControlRiesgo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<ControlRiesgo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ControlRiesgo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdControl, Nombre FROM tblControlRiesgo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<ControlRiesgo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(ControlRiesgo entity)
        {
            var sql = "UPDATE tblControlRiesgo SET IdEmpresa = @idempresa, IdControl = @idcontrol, Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdControl = @idcontrol;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdControl = entity.IdControl });
                return _affectedRows;
            }
        }
    }
}
