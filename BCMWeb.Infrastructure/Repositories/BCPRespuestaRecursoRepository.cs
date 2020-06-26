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
    public class BCPRespuestaRecursoRepository : IBCPRespuestaRecursoRepository
    {
        private readonly IConfiguration _configuration;

        public BCPRespuestaRecursoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPRespuestaRecurso entity)
        {
            var sql = "INSERT INTO tblBCPRespuestaRecurso (IdEmpresa, IdDocumentoBCP, , Cantidad, Nombre) VALUES(@IdEmpresa, @IdDocumentoBCP, , @Cantidad, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idrespuestarecurso)
        {
            var sql = "DELETE FROM tblBCPRespuestaRecurso WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdRespuestaRecurso = @idrespuestarecurso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdRespuestaRecurso = idrespuestarecurso });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPRespuestaRecurso> Get(long idempresa, long iddocumentobcp, long idrespuestarecurso)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdRespuestaRecurso, Cantidad, Nombre FROM tblBCPRespuestaRecurso  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdRespuestaRecurso = @idrespuestarecurso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRespuestaRecurso>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdRespuestaRecurso = idrespuestarecurso });
                BCPRespuestaRecurso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPRespuestaRecurso> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPRespuestaRecurso>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdRespuestaRecurso, Cantidad, Nombre FROM tblBCPRespuestaRecurso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRespuestaRecurso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPRespuestaRecurso entity)
        {
            var sql = "UPDATE tblBCPRespuestaRecurso SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, , Cantidad = @cantidad, Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdRespuestaRecurso = @idrespuestarecurso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdRespuestaRecurso = entity.IdRespuestaRecurso });
                return _affectedRows;
            }
        }
    }
}
