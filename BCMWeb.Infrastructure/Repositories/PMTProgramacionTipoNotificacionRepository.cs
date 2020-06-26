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
    public class PMTProgramacionTipoNotificacionRepository : IPMTProgramacionTipoNotificacionRepository
    {
        private readonly IConfiguration _configuration;

        public PMTProgramacionTipoNotificacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PMTProgramacionTipoNotificacion entity)
        {
            var sql = "INSERT INTO tblPMTProgramacionTipoNotificacion (IdTipoNotificacion) VALUES(@IdTipoNotificacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(short idtiponotificacion)
        {
            var sql = "DELETE FROM tblPMTProgramacionTipoNotificacion WHERE IdTipoNotificacion = @idtiponotificacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoNotificacion = idtiponotificacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PMTProgramacionTipoNotificacion> Get(short idtiponotificacion)
        {
            var sql = "SELECT IdTipoNotificacion FROM tblPMTProgramacionTipoNotificacion  WHERE IdTipoNotificacion = @idtiponotificacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacionTipoNotificacion>(sql, new { IdTipoNotificacion = idtiponotificacion });
                PMTProgramacionTipoNotificacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PMTProgramacionTipoNotificacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PMTProgramacionTipoNotificacion>> GetAll()
        {
            var sql = "SELECT IdTipoNotificacion FROM tblPMTProgramacionTipoNotificacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacionTipoNotificacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PMTProgramacionTipoNotificacion entity)
        {
            var sql = "UPDATE tblPMTProgramacionTipoNotificacion SET IdTipoNotificacion = @idtiponotificacion WHERE IdTipoNotificacion = @idtiponotificacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoNotificacion = entity.IdTipoNotificacion });
                return _affectedRows;
            }
        }
    }
}
