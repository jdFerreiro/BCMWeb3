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
    public class PMTProgramacionDocumentosRepository : IPMTProgramacionDocumentosRepository
    {
        private readonly IConfiguration _configuration;

        public PMTProgramacionDocumentosRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PMTProgramacionDocumentos entity)
        {
            var sql = "INSERT INTO tblPMTProgramacionDocumentos (IdPMTProgramacion, IdEmpresa, IdModulo, IdDocumento, IdTipoDocumento) VALUES(@IdPMTProgramacion, @IdEmpresa, @IdModulo, @IdDocumento, @IdTipoDocumento);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idpmtprogramacion, long idempresa, long idmodulo, long iddocumento)
        {
            var sql = "DELETE FROM tblPMTProgramacionDocumentos WHERE IdPMTProgramacion = @idpmtprogramacion AND IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdDocumento = @iddocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPMTProgramacion = idpmtprogramacion, IdEmpresa = idempresa, IdModulo = idmodulo, IdDocumento = iddocumento });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PMTProgramacionDocumentos> Get(long idpmtprogramacion, long idempresa, long idmodulo, long iddocumento)
        {
            var sql = "SELECT IdPMTProgramacion, IdEmpresa, IdModulo, IdDocumento, IdTipoDocumento FROM tblPMTProgramacionDocumentos  WHERE IdPMTProgramacion = @idpmtprogramacion AND IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdDocumento = @iddocumento;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacionDocumentos>(sql, new { IdPMTProgramacion = idpmtprogramacion, IdEmpresa = idempresa, IdModulo = idmodulo, IdDocumento = iddocumento });
                PMTProgramacionDocumentos _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PMTProgramacionDocumentos> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PMTProgramacionDocumentos>> GetAll()
        {
            var sql = "SELECT IdPMTProgramacion, IdEmpresa, IdModulo, IdDocumento, IdTipoDocumento FROM tblPMTProgramacionDocumentos ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacionDocumentos>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PMTProgramacionDocumentos entity)
        {
            var sql = "UPDATE tblPMTProgramacionDocumentos SET IdPMTProgramacion = @idpmtprogramacion, IdEmpresa = @idempresa, IdModulo = @idmodulo, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento WHERE IdPMTProgramacion = @idpmtprogramacion AND IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdDocumento = @iddocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPMTProgramacion = entity.IdPMTProgramacion, IdEmpresa = entity.IdEmpresa, IdModulo = entity.IdModulo, IdDocumento = entity.IdDocumento });
                return _affectedRows;
            }
        }
    }
}
