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
    public class PMTMensajeActualizacionRepository : IPMTMensajeActualizacionRepository
    {
        private readonly IConfiguration _configuration;

        public PMTMensajeActualizacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PMTMensajeActualizacion entity)
        {
            var sql = "INSERT INTO tblPMTMensajeActualizacion (IdEmpresa, , IdModulo, FechaActualizacion, FechaUltimoEnvio) VALUES(@IdEmpresa, , @IdModulo, @FechaActualizacion, @FechaUltimoEnvio);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idmensaje, long idmodulo)
        {
            var sql = "DELETE FROM tblPMTMensajeActualizacion WHERE IdEmpresa = @idempresa AND IdMensaje = @idmensaje AND IdModulo = @idmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdMensaje = idmensaje, IdModulo = idmodulo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PMTMensajeActualizacion> Get(long idempresa, long idmensaje, long idmodulo)
        {
            var sql = "SELECT IdEmpresa, IdMensaje, IdModulo, FechaActualizacion, FechaUltimoEnvio FROM tblPMTMensajeActualizacion  WHERE IdEmpresa = @idempresa AND IdMensaje = @idmensaje AND IdModulo = @idmodulo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTMensajeActualizacion>(sql, new { IdEmpresa = idempresa, IdMensaje = idmensaje, IdModulo = idmodulo });
                PMTMensajeActualizacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PMTMensajeActualizacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PMTMensajeActualizacion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdMensaje, IdModulo, FechaActualizacion, FechaUltimoEnvio FROM tblPMTMensajeActualizacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTMensajeActualizacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PMTMensajeActualizacion entity)
        {
            var sql = "UPDATE tblPMTMensajeActualizacion SET IdEmpresa = @idempresa, , IdModulo = @idmodulo, FechaActualizacion = @fechaactualizacion, FechaUltimoEnvio = @fechaultimoenvio WHERE IdEmpresa = @idempresa AND IdMensaje = @idmensaje AND IdModulo = @idmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdMensaje = entity.IdMensaje, IdModulo = entity.IdModulo });
                return _affectedRows;
            }
        }
    }
}
