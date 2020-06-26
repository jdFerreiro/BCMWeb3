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
    public class BCPDocumentoRepository : IBCPDocumentoRepository
    {
        private readonly IConfiguration _configuration;

        public BCPDocumentoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPDocumento entity)
        {
            var sql = "INSERT INTO tblBCPDocumento (IdEmpresa, , IdDocumento, IdTipoDocumento, IdDocumentoBIA, IdProceso, IdUnidadOrganizativa, Proceso, SubProceso, Responsable) VALUES(@IdEmpresa, , @IdDocumento, @IdTipoDocumento, @IdDocumentoBIA, @IdProceso, @IdUnidadOrganizativa, @Proceso, @SubProceso, @Responsable);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp)
        {
            var sql = "DELETE FROM tblBCPDocumento WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp });
                return _affectedRows;
            }
        }
        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }
        public async Task<BCPDocumento> Get(long idempresa, long iddocumentobcp)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdDocumento, IdTipoDocumento, IdDocumentoBIA, IdProceso, IdUnidadOrganizativa, Proceso, SubProceso, Responsable FROM tblBCPDocumento  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPDocumento>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp });
                BCPDocumento _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public Task<BCPDocumento> Get(long id)
        {
            throw new System.NotImplementedException();
        }
        public async Task<IEnumerable<BCPDocumento>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdDocumento, IdTipoDocumento, IdDocumentoBIA, IdProceso, IdUnidadOrganizativa, Proceso, SubProceso, Responsable FROM tblBCPDocumento ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPDocumento>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPDocumento entity)
        {
            var sql = "UPDATE tblBCPDocumento SET IdEmpresa = @idempresa, , IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, IdUnidadOrganizativa = @idunidadorganizativa, Proceso = @proceso, SubProceso = @subproceso, Responsable = @responsable WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP });
                return _affectedRows;
            }
        }
    }
}
