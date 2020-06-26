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
    public class MesRepository : IMesRepository
    {
        private readonly IConfiguration _configuration;

        public MesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Mes entity)
        {
            var sql = "INSERT INTO tblMes (IdMes) VALUES(@IdMes);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idmes)
        {
            var sql = "DELETE FROM tblMes WHERE IdMes = @idmes;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdMes = idmes });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Mes> Get(int idmes)
        {
            var sql = "SELECT IdMes FROM tblMes  WHERE IdMes = @idmes;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Mes>(sql, new { IdMes = idmes });
                Mes _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Mes> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Mes>> GetAll()
        {
            var sql = "SELECT IdMes FROM tblMes ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Mes>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Mes entity)
        {
            var sql = "UPDATE tblMes SET IdMes = @idmes WHERE IdMes = @idmes;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdMes = entity.IdMes });
                return _affectedRows;
            }
        }
    }
}
