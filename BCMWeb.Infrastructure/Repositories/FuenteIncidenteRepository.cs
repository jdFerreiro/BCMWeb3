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
    public class FuenteIncidenteRepository : IFuenteIncidenteRepository
    {
        private readonly IConfiguration _configuration;

        public FuenteIncidenteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(FuenteIncidente entity)
        {
            var sql = "INSERT INTO tblFuenteIncidente () VALUES();";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idfuenteincidente)
        {
            var sql = "DELETE FROM tblFuenteIncidente WHERE IdFuenteIncidente = @idfuenteincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdFuenteIncidente = idfuenteincidente });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<FuenteIncidente> Get(int idfuenteincidente)
        {
            var sql = "SELECT IdFuenteIncidente FROM tblFuenteIncidente  WHERE IdFuenteIncidente = @idfuenteincidente;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<FuenteIncidente>(sql, new { IdFuenteIncidente = idfuenteincidente });
                FuenteIncidente _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<FuenteIncidente> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<FuenteIncidente>> GetAll()
        {
            var sql = "SELECT IdFuenteIncidente FROM tblFuenteIncidente ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<FuenteIncidente>(sql);
                return _result;
            }

        }
        public async Task<long> Update(FuenteIncidente entity)
        {
            var sql = "UPDATE tblFuenteIncidente SET  WHERE IdFuenteIncidente = @idfuenteincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdFuenteIncidente = entity.IdFuenteIncidente });
                return _affectedRows;
            }
        }
    }
}
