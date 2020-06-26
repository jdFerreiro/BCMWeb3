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
    public class DocumentoEntrevistaRepository : IDocumentoEntrevistaRepository
    {
        private readonly IConfiguration _configuration;

        public DocumentoEntrevistaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DocumentoEntrevista entity)
        {
            var sql = "INSERT INTO tblDocumentoEntrevista (IdEmpresa, IdDocumento, IdTipoDocumento, , FechaInicio, FechaFinal) VALUES(@IdEmpresa, @IdDocumento, @IdTipoDocumento, , @FechaInicio, @FechaFinal);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long identrevista)
        {
            var sql = "DELETE FROM tblDocumentoEntrevista WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdEntrevista = @identrevista;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdEntrevista = identrevista });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DocumentoEntrevista> Get(long idempresa, long iddocumento, long idtipodocumento, long identrevista)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdEntrevista, FechaInicio, FechaFinal FROM tblDocumentoEntrevista  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdEntrevista = @identrevista;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoEntrevista>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdEntrevista = identrevista });
                DocumentoEntrevista _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DocumentoEntrevista> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DocumentoEntrevista>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdEntrevista, FechaInicio, FechaFinal FROM tblDocumentoEntrevista ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoEntrevista>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DocumentoEntrevista entity)
        {
            var sql = "UPDATE tblDocumentoEntrevista SET IdEmpresa = @idempresa, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento, , FechaInicio = @fechainicio, FechaFinal = @fechafinal WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdEntrevista = @identrevista;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdTipoDocumento = entity.IdTipoDocumento, IdEntrevista = entity.IdEntrevista });
                return _affectedRows;
            }
        }
    }
}
