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
    public class DocumentoAprobacionRepository : IDocumentoAprobacionRepository
    {
        private readonly IConfiguration _configuration;

        public DocumentoAprobacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DocumentoAprobacion entity)
        {
            var sql = "INSERT INTO tblDocumentoAprobacion (IdEmpresa, IdDocumento, IdTipoDocumento, , Fecha, IdPersona, Procesado, Aprobado) VALUES(@IdEmpresa, @IdDocumento, @IdTipoDocumento, , @Fecha, @IdPersona, @Procesado, @Aprobado);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idaprobacion)
        {
            var sql = "DELETE FROM tblDocumentoAprobacion WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdAprobacion = @idaprobacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdAprobacion = idaprobacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DocumentoAprobacion> Get(long idempresa, long iddocumento, long idtipodocumento, long idaprobacion)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdAprobacion, Fecha, IdPersona, Procesado, Aprobado FROM tblDocumentoAprobacion  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdAprobacion = @idaprobacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoAprobacion>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdAprobacion = idaprobacion });
                DocumentoAprobacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DocumentoAprobacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DocumentoAprobacion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdAprobacion, Fecha, IdPersona, Procesado, Aprobado FROM tblDocumentoAprobacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoAprobacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DocumentoAprobacion entity)
        {
            var sql = "UPDATE tblDocumentoAprobacion SET IdEmpresa = @idempresa, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento, , Fecha = @fecha, IdPersona = @idpersona, Procesado = @procesado, Aprobado = @aprobado WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdAprobacion = @idaprobacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdTipoDocumento = entity.IdTipoDocumento, IdAprobacion = entity.IdAprobacion });
                return _affectedRows;
            }
        }
    }
}
