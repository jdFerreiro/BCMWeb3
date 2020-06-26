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
    public class PBEPruebaEstatusRepository : IPBEPruebaEstatusRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaEstatusRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaEstatus entity)
        {
            var sql = "INSERT INTO tblPBEPruebaEstatus (IdEstatus) VALUES(@IdEstatus);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(short idestatus)
        {
            var sql = "DELETE FROM tblPBEPruebaEstatus WHERE IdEstatus = @idestatus;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstatus = idestatus });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PBEPruebaEstatus> Get(short idestatus)
        {
            var sql = "SELECT IdEstatus FROM tblPBEPruebaEstatus  WHERE IdEstatus = @idestatus;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEstatus>(sql, new { IdEstatus = idestatus });
                PBEPruebaEstatus _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaEstatus> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaEstatus>> GetAll()
        {
            var sql = "SELECT IdEstatus FROM tblPBEPruebaEstatus ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEstatus>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaEstatus entity)
        {
            var sql = "UPDATE tblPBEPruebaEstatus SET IdEstatus = @idestatus WHERE IdEstatus = @idestatus;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstatus = entity.IdEstatus });
                return _affectedRows;
            }
        }
    }
}
