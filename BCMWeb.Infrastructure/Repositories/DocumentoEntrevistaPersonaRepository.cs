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
    public class DocumentoEntrevistaPersonaRepository : IDocumentoEntrevistaPersonaRepository
    {
        private readonly IConfiguration _configuration;

        public DocumentoEntrevistaPersonaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DocumentoEntrevistaPersona entity)
        {
            var sql = "INSERT INTO tblDocumentoEntrevistaPersona (IdEmpresa, IdDocumento, IdTipoDocumento, IdEntrevista, IdPersonaEntrevista, EsEntrevistador, Nombre, Empresa) VALUES(@IdEmpresa, @IdDocumento, @IdTipoDocumento, @IdEntrevista, @IdPersonaEntrevista, @EsEntrevistador, @Nombre, @Empresa);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long identrevista, long idpersonaentrevista)
        {
            var sql = "DELETE FROM tblDocumentoEntrevistaPersona WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdEntrevista = @identrevista AND IdPersonaEntrevista = @idpersonaentrevista;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdEntrevista = identrevista, IdPersonaEntrevista = idpersonaentrevista });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DocumentoEntrevistaPersona> Get(long idempresa, long iddocumento, long idtipodocumento, long identrevista, long idpersonaentrevista)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdEntrevista, IdPersonaEntrevista, EsEntrevistador, Nombre, Empresa FROM tblDocumentoEntrevistaPersona  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdEntrevista = @identrevista AND IdPersonaEntrevista = @idpersonaentrevista;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoEntrevistaPersona>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdEntrevista = identrevista, IdPersonaEntrevista = idpersonaentrevista });
                DocumentoEntrevistaPersona _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DocumentoEntrevistaPersona> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DocumentoEntrevistaPersona>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdEntrevista, IdPersonaEntrevista, EsEntrevistador, Nombre, Empresa FROM tblDocumentoEntrevistaPersona ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoEntrevistaPersona>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DocumentoEntrevistaPersona entity)
        {
            var sql = "UPDATE tblDocumentoEntrevistaPersona SET IdEmpresa = @idempresa, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento, IdEntrevista = @identrevista, IdPersonaEntrevista = @idpersonaentrevista, EsEntrevistador = @esentrevistador, Nombre = @nombre, Empresa = @empresa WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdEntrevista = @identrevista AND IdPersonaEntrevista = @idpersonaentrevista;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdTipoDocumento = entity.IdTipoDocumento, IdEntrevista = entity.IdEntrevista, IdPersonaEntrevista = entity.IdPersonaEntrevista });
                return _affectedRows;
            }
        }
    }
}
