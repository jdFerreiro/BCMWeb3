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
    public class BIADocumentoRepository : IBIADocumentoRepository
    {
        private readonly IConfiguration _configuration;

        public BIADocumentoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIADocumento entity)
        {
            var sql = "INSERT INTO tblBIADocumento (IdEmpresa, , IdDocumento, IdUnidadOrganizativa, IdCadenaServicio, IdTipoDocumento) VALUES(@IdEmpresa, , @IdDocumento, @IdUnidadOrganizativa, @IdCadenaServicio, @IdTipoDocumento);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia)
        {
            var sql = "DELETE FROM tblBIADocumento WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIADocumento> Get(long idempresa, long iddocumentobia)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdDocumento, IdUnidadOrganizativa, IdCadenaServicio, IdTipoDocumento FROM tblBIADocumento  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIADocumento>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia });
                BIADocumento _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIADocumento> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIADocumento>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdDocumento, IdUnidadOrganizativa, IdCadenaServicio, IdTipoDocumento FROM tblBIADocumento ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIADocumento>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIADocumento entity)
        {
            var sql = "UPDATE tblBIADocumento SET IdEmpresa = @idempresa, , IdDocumento = @iddocumento, IdUnidadOrganizativa = @idunidadorganizativa, IdCadenaServicio = @idcadenaservicio, IdTipoDocumento = @idtipodocumento WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA });
                return _affectedRows;
            }
        }

        Task<long> IBIADocumentoRepository.Delete(long idempresa, long iddocumentobia)
        {
            throw new System.NotImplementedException();
        }
    }
}
