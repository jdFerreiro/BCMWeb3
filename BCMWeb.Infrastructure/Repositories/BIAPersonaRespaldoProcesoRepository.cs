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
    public class BIAPersonaRespaldoProcesoRepository : IBIAPersonaRespaldoProcesoRepository
    {
        private readonly IConfiguration _configuration;

        public BIAPersonaRespaldoProcesoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAPersonaRespaldoProceso entity)
        {
            var sql = "INSERT INTO tblBIAPersonaRespaldoProceso (IdEmpresa, IdDocumentoBIA, IdPersona, IdProceso) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdPersona, @IdProceso);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idpersona, long idproceso)
        {
            var sql = "DELETE FROM tblBIAPersonaRespaldoProceso WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdPersona = @idpersona AND IdProceso = @idproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdPersona = idpersona, IdProceso = idproceso });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAPersonaRespaldoProceso> Get(long idempresa, long iddocumentobia, long idpersona, long idproceso)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdPersona, IdProceso FROM tblBIAPersonaRespaldoProceso  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdPersona = @idpersona AND IdProceso = @idproceso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAPersonaRespaldoProceso>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdPersona = idpersona, IdProceso = idproceso });
                BIAPersonaRespaldoProceso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAPersonaRespaldoProceso> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAPersonaRespaldoProceso>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdPersona, IdProceso FROM tblBIAPersonaRespaldoProceso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAPersonaRespaldoProceso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAPersonaRespaldoProceso entity)
        {
            var sql = "UPDATE tblBIAPersonaRespaldoProceso SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdPersona = @idpersona, IdProceso = @idproceso WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdPersona = @idpersona AND IdProceso = @idproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdPersona = entity.IdPersona, IdProceso = entity.IdProceso });
                return _affectedRows;
            }
        }
    }
}
