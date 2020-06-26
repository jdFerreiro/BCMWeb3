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
    public class DocumentoContenidoRepository : IDocumentoContenidoRepository
    {
        private readonly IConfiguration _configuration;

        public DocumentoContenidoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DocumentoContenido entity)
        {
            var sql = "INSERT INTO tblDocumentoContenido (IdEmpresa, IdDocumento, IdTipoDocumento, IdSubModulo, ContenidoBin, FechaCreacion) VALUES(@IdEmpresa, @IdDocumento, @IdTipoDocumento, @IdSubModulo, @ContenidoBin, @FechaCreacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idsubmodulo)
        {
            var sql = "DELETE FROM tblDocumentoContenido WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdSubModulo = @idsubmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdSubModulo = idsubmodulo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DocumentoContenido> Get(long idempresa, long iddocumento, long idtipodocumento, long idsubmodulo)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdSubModulo, ContenidoBin, FechaCreacion FROM tblDocumentoContenido  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdSubModulo = @idsubmodulo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoContenido>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdSubModulo = idsubmodulo });
                DocumentoContenido _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DocumentoContenido> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DocumentoContenido>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdSubModulo, ContenidoBin, FechaCreacion FROM tblDocumentoContenido ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoContenido>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DocumentoContenido entity)
        {
            var sql = "UPDATE tblDocumentoContenido SET IdEmpresa = @idempresa, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento, IdSubModulo = @idsubmodulo, ContenidoBin = @contenidobin, FechaCreacion = @fechacreacion WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdSubModulo = @idsubmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdTipoDocumento = entity.IdTipoDocumento, IdSubModulo = entity.IdSubModulo });
                return _affectedRows;
            }
        }
    }
}
