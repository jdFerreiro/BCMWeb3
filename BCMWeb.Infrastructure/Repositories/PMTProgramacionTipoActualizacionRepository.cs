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
    public class PMTProgramacionTipoActualizacionRepository : IPMTProgramacionTipoActualizacionRepository
    {
        private readonly IConfiguration _configuration;

        public PMTProgramacionTipoActualizacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PMTProgramacionTipoActualizacion entity)
        {
            var sql = "INSERT INTO tblPMTProgramacionTipoActualizacion (IdTipoActualizacion) VALUES(@IdTipoActualizacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(short idtipoactualizacion)
        {
            var sql = "DELETE FROM tblPMTProgramacionTipoActualizacion WHERE IdTipoActualizacion = @idtipoactualizacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoActualizacion = idtipoactualizacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PMTProgramacionTipoActualizacion> Get(short idtipoactualizacion)
        {
            var sql = "SELECT IdTipoActualizacion FROM tblPMTProgramacionTipoActualizacion  WHERE IdTipoActualizacion = @idtipoactualizacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacionTipoActualizacion>(sql, new { IdTipoActualizacion = idtipoactualizacion });
                PMTProgramacionTipoActualizacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PMTProgramacionTipoActualizacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PMTProgramacionTipoActualizacion>> GetAll()
        {
            var sql = "SELECT IdTipoActualizacion FROM tblPMTProgramacionTipoActualizacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacionTipoActualizacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PMTProgramacionTipoActualizacion entity)
        {
            var sql = "UPDATE tblPMTProgramacionTipoActualizacion SET IdTipoActualizacion = @idtipoactualizacion WHERE IdTipoActualizacion = @idtipoactualizacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoActualizacion = entity.IdTipoActualizacion });
                return _affectedRows;
            }
        }
    }
}
