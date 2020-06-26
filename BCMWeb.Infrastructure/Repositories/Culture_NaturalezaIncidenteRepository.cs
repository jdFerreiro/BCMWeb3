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
    public class Culture_NaturalezaIncidenteRepository : ICulture_NaturalezaIncidenteRepository
    {
        private readonly IConfiguration _configuration;

        public Culture_NaturalezaIncidenteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Culture_NaturalezaIncidente entity)
        {
            var sql = "INSERT INTO tblCulture_NaturalezaIncidente (Culture, IdNaturalezaIncidente, Descripcion) VALUES(@Culture, @IdNaturalezaIncidente, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idnaturalezaincidente)
        {
            var sql = "DELETE FROM tblCulture_NaturalezaIncidente WHERE Culture = @culture AND IdNaturalezaIncidente = @idnaturalezaincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdNaturalezaIncidente = idnaturalezaincidente });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Culture_NaturalezaIncidente> Get(string culture, int idnaturalezaincidente)
        {
            var sql = "SELECT Culture, IdNaturalezaIncidente, Descripcion FROM tblCulture_NaturalezaIncidente  WHERE Culture = @culture AND IdNaturalezaIncidente = @idnaturalezaincidente;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Culture_NaturalezaIncidente>(sql, new { Culture = culture, IdNaturalezaIncidente = idnaturalezaincidente });
                Culture_NaturalezaIncidente _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Culture_NaturalezaIncidente> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Culture_NaturalezaIncidente>> GetAll()
        {
            var sql = "SELECT Culture, IdNaturalezaIncidente, Descripcion FROM tblCulture_NaturalezaIncidente ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Culture_NaturalezaIncidente>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Culture_NaturalezaIncidente entity)
        {
            var sql = "UPDATE tblCulture_NaturalezaIncidente SET Culture = @culture, IdNaturalezaIncidente = @idnaturalezaincidente, Descripcion = @descripcion WHERE Culture = @culture AND IdNaturalezaIncidente = @idnaturalezaincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdNaturalezaIncidente = entity.IdNaturalezaIncidente });
                return _affectedRows;
            }
        }
    }
}
