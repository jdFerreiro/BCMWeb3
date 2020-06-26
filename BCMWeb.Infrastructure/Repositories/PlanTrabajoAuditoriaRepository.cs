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
    public class PlanTrabajoAuditoriaRepository : IPlanTrabajoAuditoriaRepository
    {
        private readonly IConfiguration _configuration;

        public PlanTrabajoAuditoriaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PlanTrabajoAuditoria entity)
        {
            var sql = "INSERT INTO tblPlanTrabajoAuditoria (IdEmpresa, IdAccion, IdActividad, , FechaCambioEstado, Estado, IdUsuarioCambioEstado) VALUES(@IdEmpresa, @IdAccion, @IdActividad, , @FechaCambioEstado, @Estado, @IdUsuarioCambioEstado);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idaccion, long idactividad, long idcambioestado)
        {
            var sql = "DELETE FROM tblPlanTrabajoAuditoria WHERE IdEmpresa = @idempresa AND IdAccion = @idaccion AND IdActividad = @idactividad AND IdCambioEstado = @idcambioestado;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdAccion = idaccion, IdActividad = idactividad, IdCambioEstado = idcambioestado });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PlanTrabajoAuditoria> Get(long idempresa, long idaccion, long idactividad, long idcambioestado)
        {
            var sql = "SELECT IdEmpresa, IdAccion, IdActividad, IdCambioEstado, FechaCambioEstado, Estado, IdUsuarioCambioEstado FROM tblPlanTrabajoAuditoria  WHERE IdEmpresa = @idempresa AND IdAccion = @idaccion AND IdActividad = @idactividad AND IdCambioEstado = @idcambioestado;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PlanTrabajoAuditoria>(sql, new { IdEmpresa = idempresa, IdAccion = idaccion, IdActividad = idactividad, IdCambioEstado = idcambioestado });
                PlanTrabajoAuditoria _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PlanTrabajoAuditoria> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PlanTrabajoAuditoria>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdAccion, IdActividad, IdCambioEstado, FechaCambioEstado, Estado, IdUsuarioCambioEstado FROM tblPlanTrabajoAuditoria ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PlanTrabajoAuditoria>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PlanTrabajoAuditoria entity)
        {
            var sql = "UPDATE tblPlanTrabajoAuditoria SET IdEmpresa = @idempresa, IdAccion = @idaccion, IdActividad = @idactividad, , FechaCambioEstado = @fechacambioestado, Estado = @estado, IdUsuarioCambioEstado = @idusuariocambioestado WHERE IdEmpresa = @idempresa AND IdAccion = @idaccion AND IdActividad = @idactividad AND IdCambioEstado = @idcambioestado;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdAccion = entity.IdAccion, IdActividad = entity.IdActividad, IdCambioEstado = entity.IdCambioEstado });
                return _affectedRows;
            }
        }
    }
}
