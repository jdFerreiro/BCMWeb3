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
    public class PlanTrabajoAccionRepository : IPlanTrabajoAccionRepository
    {
        private readonly IConfiguration _configuration;

        public PlanTrabajoAccionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PlanTrabajoAccion entity)
        {
            var sql = "INSERT INTO tblPlanTrabajoAccion (IdEmpresa, , Descripcion) VALUES(@IdEmpresa, , @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanaccion)
        {
            var sql = "DELETE FROM tblPlanTrabajoAccion WHERE IdEmpresa = @idempresa AND IdPlanAccion = @idplanaccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPlanAccion = idplanaccion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PlanTrabajoAccion> Get(long idempresa, long idplanaccion)
        {
            var sql = "SELECT IdEmpresa, IdPlanAccion, Descripcion FROM tblPlanTrabajoAccion  WHERE IdEmpresa = @idempresa AND IdPlanAccion = @idplanaccion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PlanTrabajoAccion>(sql, new { IdEmpresa = idempresa, IdPlanAccion = idplanaccion });
                PlanTrabajoAccion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PlanTrabajoAccion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PlanTrabajoAccion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanAccion, Descripcion FROM tblPlanTrabajoAccion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PlanTrabajoAccion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PlanTrabajoAccion entity)
        {
            var sql = "UPDATE tblPlanTrabajoAccion SET IdEmpresa = @idempresa, , Descripcion = @descripcion WHERE IdEmpresa = @idempresa AND IdPlanAccion = @idplanaccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanAccion = entity.IdPlanAccion });
                return _affectedRows;
            }
        }
    }
}
