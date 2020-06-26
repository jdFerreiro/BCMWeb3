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
    public class PlanTrabajoRepository : IPlanTrabajoRepository
    {
        private readonly IConfiguration _configuration;

        public PlanTrabajoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PlanTrabajo entity)
        {
            var sql = "INSERT INTO tblPlanTrabajo (IdEmpresa, IdAccion, , Recomendacion, Responsable, FechaPropuestaEjecucion, Ejecutada, IdActividadPadre) VALUES(@IdEmpresa, @IdAccion, , @Recomendacion, @Responsable, @FechaPropuestaEjecucion, @Ejecutada, @IdActividadPadre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idaccion, long idactividad)
        {
            var sql = "DELETE FROM tblPlanTrabajo WHERE IdEmpresa = @idempresa AND IdAccion = @idaccion AND IdActividad = @idactividad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdAccion = idaccion, IdActividad = idactividad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PlanTrabajo> Get(long idempresa, long idaccion, long idactividad)
        {
            var sql = "SELECT IdEmpresa, IdAccion, IdActividad, Recomendacion, Responsable, FechaPropuestaEjecucion, Ejecutada, IdActividadPadre FROM tblPlanTrabajo  WHERE IdEmpresa = @idempresa AND IdAccion = @idaccion AND IdActividad = @idactividad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PlanTrabajo>(sql, new { IdEmpresa = idempresa, IdAccion = idaccion, IdActividad = idactividad });
                PlanTrabajo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PlanTrabajo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PlanTrabajo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdAccion, IdActividad, Recomendacion, Responsable, FechaPropuestaEjecucion, Ejecutada, IdActividadPadre FROM tblPlanTrabajo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PlanTrabajo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PlanTrabajo entity)
        {
            var sql = "UPDATE tblPlanTrabajo SET IdEmpresa = @idempresa, IdAccion = @idaccion, , Recomendacion = @recomendacion, Responsable = @responsable, FechaPropuestaEjecucion = @fechapropuestaejecucion, Ejecutada = @ejecutada, IdActividadPadre = @idactividadpadre WHERE IdEmpresa = @idempresa AND IdAccion = @idaccion AND IdActividad = @idactividad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdAccion = entity.IdAccion, IdActividad = entity.IdActividad });
                return _affectedRows;
            }
        }
    }
}
