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
    public class NaturalezaIncidenteRepository : INaturalezaIncidenteRepository
    {
        private readonly IConfiguration _configuration;

        public NaturalezaIncidenteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(NaturalezaIncidente entity)
        {
            var sql = "INSERT INTO tblNaturalezaIncidente () VALUES();";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idnaturalezaincidente)
        {
            var sql = "DELETE FROM tblNaturalezaIncidente WHERE IdNaturalezaIncidente = @idnaturalezaincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdNaturalezaIncidente = idnaturalezaincidente });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<NaturalezaIncidente> Get(int idnaturalezaincidente)
        {
            var sql = "SELECT IdNaturalezaIncidente FROM tblNaturalezaIncidente  WHERE IdNaturalezaIncidente = @idnaturalezaincidente;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<NaturalezaIncidente>(sql, new { IdNaturalezaIncidente = idnaturalezaincidente });
                NaturalezaIncidente _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<NaturalezaIncidente> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<NaturalezaIncidente>> GetAll()
        {
            var sql = "SELECT IdNaturalezaIncidente FROM tblNaturalezaIncidente ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<NaturalezaIncidente>(sql);
                return _result;
            }

        }
        public async Task<long> Update(NaturalezaIncidente entity)
        {
            var sql = "UPDATE tblNaturalezaIncidente SET  WHERE IdNaturalezaIncidente = @idnaturalezaincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdNaturalezaIncidente = entity.IdNaturalezaIncidente });
                return _affectedRows;
            }
        }
    }
}
