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
    public class BCPReanudacionTareaRepository : IBCPReanudacionTareaRepository
    {
        private readonly IConfiguration _configuration;

        public BCPReanudacionTareaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPReanudacionTarea entity)
        {
            var sql = "INSERT INTO tblBCPReanudacionTarea (IdEmpresa, IdDocumentoBCP, , Nombre) VALUES(@IdEmpresa, @IdDocumentoBCP, , @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea)
        {
            var sql = "DELETE FROM tblBCPReanudacionTarea WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPReanudacionTarea = @idbcpreanudaciontarea;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPReanudacionTarea = idbcpreanudaciontarea });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPReanudacionTarea> Get(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPReanudacionTarea, Nombre FROM tblBCPReanudacionTarea  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPReanudacionTarea = @idbcpreanudaciontarea;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPReanudacionTarea>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPReanudacionTarea = idbcpreanudaciontarea });
                BCPReanudacionTarea _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPReanudacionTarea> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPReanudacionTarea>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPReanudacionTarea, Nombre FROM tblBCPReanudacionTarea ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPReanudacionTarea>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPReanudacionTarea entity)
        {
            var sql = "UPDATE tblBCPReanudacionTarea SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, , Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPReanudacionTarea = @idbcpreanudaciontarea;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdBCPReanudacionTarea = entity.IdBCPReanudacionTarea });
                return _affectedRows;
            }
        }
    }
}
