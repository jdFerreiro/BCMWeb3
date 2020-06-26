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
    public class PBEPruebaPlanificacionEjercicioRecursoRepository : IPBEPruebaPlanificacionEjercicioRecursoRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaPlanificacionEjercicioRecursoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaPlanificacionEjercicioRecurso entity)
        {
            var sql = "INSERT INTO tblPBEPruebaPlanificacionEjercicioRecurso (IdEmpresa, IdPlanificacion, IdEjercicio, , Nombre, Descripcion, Cantidad, Responsable) VALUES(@IdEmpresa, @IdPlanificacion, @IdEjercicio, , @Nombre, @Descripcion, @Cantidad, @Responsable);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idrecurso)
        {
            var sql = "DELETE FROM tblPBEPruebaPlanificacionEjercicioRecurso WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdRecurso = @idrecurso;";
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

        public async Task<PBEPruebaPlanificacionEjercicioRecurso> Get(long idempresa, long idplanificacion, long idejercicio, long idrecurso)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, IdRecurso, Nombre, Descripcion, Cantidad, Responsable FROM tblPBEPruebaPlanificacionEjercicioRecurso  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdRecurso = @idrecurso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacionEjercicioRecurso>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdEjercicio = idejercicio, IdRecurso = idrecurso });
                PBEPruebaPlanificacionEjercicioRecurso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaPlanificacionEjercicioRecurso> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaPlanificacionEjercicioRecurso>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, IdRecurso, Nombre, Descripcion, Cantidad, Responsable FROM tblPBEPruebaPlanificacionEjercicioRecurso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacionEjercicioRecurso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaPlanificacionEjercicioRecurso entity)
        {
            var sql = "UPDATE tblPBEPruebaPlanificacionEjercicioRecurso SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, IdEjercicio = @idejercicio, , Nombre = @nombre, Descripcion = @descripcion, Cantidad = @cantidad, Responsable = @responsable WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdRecurso = @idrecurso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion, IdEjercicio = entity.IdEjercicio, IdRecurso = entity.IdRecurso });
                return _affectedRows;
            }
        }
    }
}
