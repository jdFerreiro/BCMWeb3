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
    public class DocumentoCertificacionRepository : IDocumentoCertificacionRepository
    {
        private readonly IConfiguration _configuration;

        public DocumentoCertificacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DocumentoCertificacion entity)
        {
            var sql = "INSERT INTO tblDocumentoCertificacion (IdEmpresa, IdDocumento, IdTipoDocumento, , Fecha, IdPersona, Procesado, Certificado) VALUES(@IdEmpresa, @IdDocumento, @IdTipoDocumento, , @Fecha, @IdPersona, @Procesado, @Certificado);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idcertificacion)
        {
            var sql = "DELETE FROM tblDocumentoCertificacion WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdCertificacion = @idcertificacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdCertificacion = idcertificacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DocumentoCertificacion> Get(long idempresa, long iddocumento, long idtipodocumento, long idcertificacion)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdCertificacion, Fecha, IdPersona, Procesado, Certificado FROM tblDocumentoCertificacion  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdCertificacion = @idcertificacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoCertificacion>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdCertificacion = idcertificacion });
                DocumentoCertificacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DocumentoCertificacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DocumentoCertificacion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdCertificacion, Fecha, IdPersona, Procesado, Certificado FROM tblDocumentoCertificacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoCertificacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DocumentoCertificacion entity)
        {
            var sql = "UPDATE tblDocumentoCertificacion SET IdEmpresa = @idempresa, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento, , Fecha = @fecha, IdPersona = @idpersona, Procesado = @procesado, Certificado = @certificado WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdCertificacion = @idcertificacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdTipoDocumento = entity.IdTipoDocumento, IdCertificacion = entity.IdCertificacion });
                return _affectedRows;
            }
        }
    }
}
