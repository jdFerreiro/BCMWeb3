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
    public class PlanTrabajoEstatusRepository : IPlanTrabajoEstatusRepository
    {
        private readonly IConfiguration _configuration;

        public PlanTrabajoEstatusRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PlanTrabajoEstatus entity)
        {
            var sql = "INSERT INTO tblPlanTrabajoEstatus (IdEstatusActividad) VALUES(@IdEstatusActividad);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(short idestatusactividad)
        {
            var sql = "DELETE FROM tblPlanTrabajoEstatus WHERE IdEstatusActividad = @idestatusactividad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstatusActividad = idestatusactividad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PlanTrabajoEstatus> Get(short idestatusactividad)
        {
            var sql = "SELECT IdEstatusActividad FROM tblPlanTrabajoEstatus  WHERE IdEstatusActividad = @idestatusactividad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PlanTrabajoEstatus>(sql, new { IdEstatusActividad = idestatusactividad });
                PlanTrabajoEstatus _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PlanTrabajoEstatus> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PlanTrabajoEstatus>> GetAll()
        {
            var sql = "SELECT IdEstatusActividad FROM tblPlanTrabajoEstatus ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PlanTrabajoEstatus>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PlanTrabajoEstatus entity)
        {
            var sql = "UPDATE tblPlanTrabajoEstatus SET IdEstatusActividad = @idestatusactividad WHERE IdEstatusActividad = @idestatusactividad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstatusActividad = entity.IdEstatusActividad });
                return _affectedRows;
            }
        }
    }
}
