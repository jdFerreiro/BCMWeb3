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
    public class DocumentoAnexoRepository : IDocumentoAnexoRepository
    {
        private readonly IConfiguration _configuration;

        public DocumentoAnexoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DocumentoAnexo entity)
        {
            var sql = "INSERT INTO tblDocumentoAnexo (IdEmpresa, IdDocumento, IdTipoDocumento, , ParentId, Nombre, IsFolder, Data, LastWriteTime) VALUES(@IdEmpresa, @IdDocumento, @IdTipoDocumento, , @ParentId, @Nombre, @IsFolder, @Data, @LastWriteTime);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idanexo)
        {
            var sql = "DELETE FROM tblDocumentoAnexo WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdAnexo = @idanexo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdAnexo = idanexo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DocumentoAnexo> Get(long idempresa, long iddocumento, long idtipodocumento, long idanexo)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdAnexo, ParentId, Nombre, IsFolder, Data, LastWriteTime FROM tblDocumentoAnexo  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdAnexo = @idanexo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoAnexo>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdAnexo = idanexo });
                DocumentoAnexo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DocumentoAnexo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DocumentoAnexo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdAnexo, ParentId, Nombre, IsFolder, Data, LastWriteTime FROM tblDocumentoAnexo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoAnexo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DocumentoAnexo entity)
        {
            var sql = "UPDATE tblDocumentoAnexo SET IdEmpresa = @idempresa, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento, , ParentId = @parentid, Nombre = @nombre, IsFolder = @isfolder, Data = @data, LastWriteTime = @lastwritetime WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdAnexo = @idanexo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdTipoDocumento = entity.IdTipoDocumento, IdAnexo = entity.IdAnexo });
                return _affectedRows;
            }
        }
    }
}
