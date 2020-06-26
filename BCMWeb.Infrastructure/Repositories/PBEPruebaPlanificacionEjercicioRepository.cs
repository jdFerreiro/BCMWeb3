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
    public class PBEPruebaPlanificacionEjercicioRepository : IPBEPruebaPlanificacionEjercicioRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaPlanificacionEjercicioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaPlanificacionEjercicio entity)
        {
            var sql = "INSERT INTO tblPBEPruebaPlanificacionEjercicio (IdEmpresa, IdPlanificacion, , Nombre, Descripcion, FechaInicio, DuracionHoras, DuracionMinutos) VALUES(@IdEmpresa, @IdPlanificacion, , @Nombre, @Descripcion, @FechaInicio, @DuracionHoras, @DuracionMinutos);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion, long idejercicio)
        {
            var sql = "DELETE FROM tblPBEPruebaPlanificacionEjercicio WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdEjercicio = idejercicio });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PBEPruebaPlanificacionEjercicio> Get(long idempresa, long idplanificacion, long idejercicio)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, Nombre, Descripcion, FechaInicio, DuracionHoras, DuracionMinutos FROM tblPBEPruebaPlanificacionEjercicio  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacionEjercicio>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdEjercicio = idejercicio });
                PBEPruebaPlanificacionEjercicio _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaPlanificacionEjercicio> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaPlanificacionEjercicio>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, Nombre, Descripcion, FechaInicio, DuracionHoras, DuracionMinutos FROM tblPBEPruebaPlanificacionEjercicio ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacionEjercicio>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaPlanificacionEjercicio entity)
        {
            var sql = "UPDATE tblPBEPruebaPlanificacionEjercicio SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, , Nombre = @nombre, Descripcion = @descripcion, FechaInicio = @fechainicio, DuracionHoras = @duracionhoras, DuracionMinutos = @duracionminutos WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion, IdEjercicio = entity.IdEjercicio });
                return _affectedRows;
            }
        }
    }
}
