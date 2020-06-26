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
    public class DocumentoRepository : IDocumentoRepository
    {
        private readonly IConfiguration _configuration;

        public DocumentoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Documento entity)
        {
            var sql = "INSERT INTO tblDocumento (IdEmpresa, , IdTipoDocumento, NroDocumento, FechaCreacion, FechaUltimaModificacion, IdEstadoDocumento, FechaEstadoDocumento, Negocios, NroVersion, VersionOriginal, IdPersonaResponsable, RequiereCertificacion) VALUES(@IdEmpresa, , @IdTipoDocumento, @NroDocumento, @FechaCreacion, @FechaUltimaModificacion, @IdEstadoDocumento, @FechaEstadoDocumento, @Negocios, @NroVersion, @VersionOriginal, @IdPersonaResponsable, @RequiereCertificacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento)
        {
            var sql = "DELETE FROM tblDocumento WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Documento> Get(long idempresa, long iddocumento, long idtipodocumento)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, NroDocumento, FechaCreacion, FechaUltimaModificacion, IdEstadoDocumento, FechaEstadoDocumento, Negocios, NroVersion, VersionOriginal, IdPersonaResponsable, RequiereCertificacion FROM tblDocumento  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Documento>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento });
                Documento _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Documento> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Documento>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, NroDocumento, FechaCreacion, FechaUltimaModificacion, IdEstadoDocumento, FechaEstadoDocumento, Negocios, NroVersion, VersionOriginal, IdPersonaResponsable, RequiereCertificacion FROM tblDocumento ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Documento>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Documento entity)
        {
            var sql = "UPDATE tblDocumento SET IdEmpresa = @idempresa, , IdTipoDocumento = @idtipodocumento, NroDocumento = @nrodocumento, FechaCreacion = @fechacreacion, FechaUltimaModificacion = @fechaultimamodificacion, IdEstadoDocumento = @idestadodocumento, FechaEstadoDocumento = @fechaestadodocumento, Negocios = @negocios, NroVersion = @nroversion, VersionOriginal = @versionoriginal, IdPersonaResponsable = @idpersonaresponsable, RequiereCertificacion = @requierecertificacion WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdTipoDocumento = entity.IdTipoDocumento });
                return _affectedRows;
            }
        }
    }
}
