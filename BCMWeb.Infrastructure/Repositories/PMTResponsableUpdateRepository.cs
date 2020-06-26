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
    public class PMTResponsableUpdateRepository : IPMTResponsableUpdateRepository
    {
        private readonly IConfiguration _configuration;

        public PMTResponsableUpdateRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PMTResponsableUpdate entity)
        {
            var sql = "INSERT INTO tblPMTResponsableUpdate (IdEmpresa, IdModulo, , IdDocumento, IdTipoNotificacion) VALUES(@IdEmpresa, @IdModulo, , @IdDocumento, @IdTipoNotificacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idmodulo, long idmensaje)
        {
            var sql = "DELETE FROM tblPMTResponsableUpdate WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdMensaje = @idmensaje;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo, IdMensaje = idmensaje });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PMTResponsableUpdate> Get(long idempresa, long idmodulo, long idmensaje)
        {
            var sql = "SELECT IdEmpresa, IdModulo, IdMensaje, IdDocumento, IdTipoNotificacion FROM tblPMTResponsableUpdate  WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdMensaje = @idmensaje;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTResponsableUpdate>(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo, IdMensaje = idmensaje });
                PMTResponsableUpdate _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PMTResponsableUpdate> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PMTResponsableUpdate>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdModulo, IdMensaje, IdDocumento, IdTipoNotificacion FROM tblPMTResponsableUpdate ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTResponsableUpdate>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PMTResponsableUpdate entity)
        {
            var sql = "UPDATE tblPMTResponsableUpdate SET IdEmpresa = @idempresa, IdModulo = @idmodulo, , IdDocumento = @iddocumento, IdTipoNotificacion = @idtiponotificacion WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdMensaje = @idmensaje;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdModulo = entity.IdModulo, IdMensaje = entity.IdMensaje });
                return _affectedRows;
            }
        }
    }
}
