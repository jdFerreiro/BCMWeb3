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
    public class BCPRespuestaAccionRepository : IBCPRespuestaAccionRepository
    {
        private readonly IConfiguration _configuration;

        public BCPRespuestaAccionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPRespuestaAccion entity)
        {
            var sql = "INSERT INTO tblBCPRespuestaAccion (IdEmpresa, IdDocumentoBCP, , IdPersona, NivelEscala, NombreEscala) VALUES(@IdEmpresa, @IdDocumentoBCP, , @IdPersona, @NivelEscala, @NombreEscala);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprespuestaaccion)
        {
            var sql = "DELETE FROM tblBCPRespuestaAccion WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRespuestaAccion = @idbcprespuestaaccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPRespuestaAccion = idbcprespuestaaccion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPRespuestaAccion> Get(long idempresa, long iddocumentobcp, long idbcprespuestaaccion)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPRespuestaAccion, IdPersona, NivelEscala, NombreEscala FROM tblBCPRespuestaAccion  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRespuestaAccion = @idbcprespuestaaccion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRespuestaAccion>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPRespuestaAccion = idbcprespuestaaccion });
                BCPRespuestaAccion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPRespuestaAccion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPRespuestaAccion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPRespuestaAccion, IdPersona, NivelEscala, NombreEscala FROM tblBCPRespuestaAccion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRespuestaAccion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPRespuestaAccion entity)
        {
            var sql = "UPDATE tblBCPRespuestaAccion SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, , IdPersona = @idpersona, NivelEscala = @nivelescala, NombreEscala = @nombreescala WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRespuestaAccion = @idbcprespuestaaccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdBCPRespuestaAccion = entity.IdBCPRespuestaAccion });
                return _affectedRows;
            }
        }
    }
}
