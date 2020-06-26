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
    public class AuditoriaProcesoCriticoRepository : IAuditoriaProcesoCriticoRepository
    {
        private readonly IConfiguration _configuration;

        public AuditoriaProcesoCriticoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(AuditoriaProcesoCritico entity)
        {
            var sql = "INSERT INTO tblAuditoriaProcesoCritico (IdProceso, , FechaActualizacion, EstadoAnterior, EstadoActual, IdEmpresa, IdUsuario) VALUES(@IdProceso, , @FechaActualizacion, @EstadoAnterior, @EstadoActual, @IdEmpresa, @IdUsuario);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idproceso, long idauditoriaprocesocritico)
        {
            var sql = "DELETE FROM tblAuditoriaProcesoCritico WHERE IdProceso = @idproceso AND IdAuditoriaProcesoCritico = @idauditoriaprocesocritico;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdProceso = idproceso, IdAuditoriaProcesoCritico = idauditoriaprocesocritico });
                return _affectedRows;
            }
        }
        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }
        public async Task<AuditoriaProcesoCritico> Get(long idproceso, long idauditoriaprocesocritico)
        {
            var sql = "SELECT IdProceso, IdAuditoriaProcesoCritico, FechaActualizacion, EstadoAnterior, EstadoActual, IdEmpresa, IdUsuario FROM tblAuditoriaProcesoCritico  WHERE IdProceso = @idproceso AND IdAuditoriaProcesoCritico = @idauditoriaprocesocritico;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<AuditoriaProcesoCritico>(sql, new { IdProceso = idproceso, IdAuditoriaProcesoCritico = idauditoriaprocesocritico });
                AuditoriaProcesoCritico _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public Task<AuditoriaProcesoCritico> Get(long id)
        {
            throw new System.NotImplementedException();
        }
        public async Task<IEnumerable<AuditoriaProcesoCritico>> GetAll()
        {
            var sql = "SELECT IdProceso, IdAuditoriaProcesoCritico, FechaActualizacion, EstadoAnterior, EstadoActual, IdEmpresa, IdUsuario FROM tblAuditoriaProcesoCritico ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<AuditoriaProcesoCritico>(sql);
                return _result;
            }

        }
        public async Task<long> Update(AuditoriaProcesoCritico entity)
        {
            var sql = "UPDATE tblAuditoriaProcesoCritico SET IdProceso = @idproceso, , FechaActualizacion = @fechaactualizacion, EstadoAnterior = @estadoanterior, EstadoActual = @estadoactual, IdEmpresa = @idempresa, IdUsuario = @idusuario WHERE IdProceso = @idproceso AND IdAuditoriaProcesoCritico = @idauditoriaprocesocritico;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdProceso = entity.IdProceso, IdAuditoriaProcesoCritico = entity.IdAuditoriaProcesoCritico });
                return _affectedRows;
            }
        }
    }
}
