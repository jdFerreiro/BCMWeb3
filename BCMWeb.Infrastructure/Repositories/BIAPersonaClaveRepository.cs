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
    public class BIAPersonaClaveRepository : IBIAPersonaClaveRepository
    {
        private readonly IConfiguration _configuration;

        public BIAPersonaClaveRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAPersonaClave entity)
        {
            var sql = "INSERT INTO tblBIAPersonaClave (IdEmpresa, IdDocumentoBIA, IdProceso, IdPersonaClave, IdDocumento, IdTipoDocumento) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, @IdPersonaClave, @IdDocumento, @IdTipoDocumento);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idpersonaclave)
        {
            var sql = "DELETE FROM tblBIAPersonaClave WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdPersonaClave = @idpersonaclave;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdPersonaClave = idpersonaclave });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAPersonaClave> Get(long idempresa, long iddocumentobia, long idproceso, long idpersonaclave)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdPersonaClave, IdDocumento, IdTipoDocumento FROM tblBIAPersonaClave  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdPersonaClave = @idpersonaclave;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAPersonaClave>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdPersonaClave = idpersonaclave });
                BIAPersonaClave _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAPersonaClave> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAPersonaClave>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdPersonaClave, IdDocumento, IdTipoDocumento FROM tblBIAPersonaClave ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAPersonaClave>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAPersonaClave entity)
        {
            var sql = "UPDATE tblBIAPersonaClave SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, IdPersonaClave = @idpersonaclave, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdPersonaClave = @idpersonaclave;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdPersonaClave = entity.IdPersonaClave });
                return _affectedRows;
            }
        }
    }
}
