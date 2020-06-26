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
    public class Cultura_PlanTrabajoEstatusRepository : ICultura_PlanTrabajoEstatusRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_PlanTrabajoEstatusRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_PlanTrabajoEstatus entity)
        {
            var sql = "INSERT INTO tblCultura_PlanTrabajoEstatus (Culture, IdEstatusActividad, Descripcion) VALUES(@Culture, @IdEstatusActividad, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, short idestatusactividad)
        {
            var sql = "DELETE FROM tblCultura_PlanTrabajoEstatus WHERE Culture = @culture AND IdEstatusActividad = @idestatusactividad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdEstatusActividad = idestatusactividad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_PlanTrabajoEstatus> Get(string culture, short idestatusactividad)
        {
            var sql = "SELECT Culture, IdEstatusActividad, Descripcion FROM tblCultura_PlanTrabajoEstatus  WHERE Culture = @culture AND IdEstatusActividad = @idestatusactividad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_PlanTrabajoEstatus>(sql, new { Culture = culture, IdEstatusActividad = idestatusactividad });
                Cultura_PlanTrabajoEstatus _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_PlanTrabajoEstatus> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_PlanTrabajoEstatus>> GetAll()
        {
            var sql = "SELECT Culture, IdEstatusActividad, Descripcion FROM tblCultura_PlanTrabajoEstatus ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_PlanTrabajoEstatus>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_PlanTrabajoEstatus entity)
        {
            var sql = "UPDATE tblCultura_PlanTrabajoEstatus SET Culture = @culture, IdEstatusActividad = @idestatusactividad, Descripcion = @descripcion WHERE Culture = @culture AND IdEstatusActividad = @idestatusactividad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdEstatusActividad = entity.IdEstatusActividad });
                return _affectedRows;
            }
        }
    }
}
