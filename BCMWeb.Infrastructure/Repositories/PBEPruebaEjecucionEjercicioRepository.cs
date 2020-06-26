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
    public class PBEPruebaEjecucionEjercicioRepository : IPBEPruebaEjecucionEjercicioRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaEjecucionEjercicioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaEjecucionEjercicio entity)
        {
            var sql = "INSERT INTO tblPBEPruebaEjecucionEjercicio (IdEmpresa, IdPlanificacion, , Nombre, Descripcion, FechaInicio, DuracionHoras, DuracionMinutos, IdEstatus, IdEjercicioPlanificacion) VALUES(@IdEmpresa, @IdPlanificacion, , @Nombre, @Descripcion, @FechaInicio, @DuracionHoras, @DuracionMinutos, @IdEstatus, @IdEjercicioPlanificacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion, long idejercicio)
        {
            var sql = "DELETE FROM tblPBEPruebaEjecucionEjercicio WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio;";
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

        public async Task<PBEPruebaEjecucionEjercicio> Get(long idempresa, long idplanificacion, long idejercicio)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, Nombre, Descripcion, FechaInicio, DuracionHoras, DuracionMinutos, IdEstatus, IdEjercicioPlanificacion FROM tblPBEPruebaEjecucionEjercicio  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionEjercicio>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdEjercicio = idejercicio });
                PBEPruebaEjecucionEjercicio _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaEjecucionEjercicio> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaEjecucionEjercicio>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, Nombre, Descripcion, FechaInicio, DuracionHoras, DuracionMinutos, IdEstatus, IdEjercicioPlanificacion FROM tblPBEPruebaEjecucionEjercicio ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionEjercicio>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaEjecucionEjercicio entity)
        {
            var sql = "UPDATE tblPBEPruebaEjecucionEjercicio SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, , Nombre = @nombre, Descripcion = @descripcion, FechaInicio = @fechainicio, DuracionHoras = @duracionhoras, DuracionMinutos = @duracionminutos, IdEstatus = @idestatus, IdEjercicioPlanificacion = @idejercicioplanificacion WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion, IdEjercicio = entity.IdEjercicio });
                return _affectedRows;
            }
        }
    }
}
