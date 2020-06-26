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
    public class PBEPruebaEjecucionEjercicioRecursoRepository : IPBEPruebaEjecucionEjercicioRecursoRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaEjecucionEjercicioRecursoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaEjecucionEjercicioRecurso entity)
        {
            var sql = "INSERT INTO tblPBEPruebaEjecucionEjercicioRecurso (IdEmpresa, IdPlanificacion, IdEjercicio, , Nombre, Descripcion, Cantidad, Responsable) VALUES(@IdEmpresa, @IdPlanificacion, @IdEjercicio, , @Nombre, @Descripcion, @Cantidad, @Responsable);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idrecurso)
        {
            var sql = "DELETE FROM tblPBEPruebaEjecucionEjercicioRecurso WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdRecurso = @idrecurso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdEjercicio = idejercicio, IdRecurso = idrecurso });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PBEPruebaEjecucionEjercicioRecurso> Get(long idempresa, long idplanificacion, long idejercicio, long idrecurso)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, IdRecurso, Nombre, Descripcion, Cantidad, Responsable FROM tblPBEPruebaEjecucionEjercicioRecurso  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdRecurso = @idrecurso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionEjercicioRecurso>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdEjercicio = idejercicio, IdRecurso = idrecurso });
                PBEPruebaEjecucionEjercicioRecurso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaEjecucionEjercicioRecurso> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaEjecucionEjercicioRecurso>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, IdRecurso, Nombre, Descripcion, Cantidad, Responsable FROM tblPBEPruebaEjecucionEjercicioRecurso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionEjercicioRecurso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaEjecucionEjercicioRecurso entity)
        {
            var sql = "UPDATE tblPBEPruebaEjecucionEjercicioRecurso SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, IdEjercicio = @idejercicio, , Nombre = @nombre, Descripcion = @descripcion, Cantidad = @cantidad, Responsable = @responsable WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdRecurso = @idrecurso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion, IdEjercicio = entity.IdEjercicio, IdRecurso = entity.IdRecurso });
                return _affectedRows;
            }
        }
    }
}
