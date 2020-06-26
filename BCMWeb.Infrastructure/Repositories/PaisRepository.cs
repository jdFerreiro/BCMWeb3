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
    public class PaisRepository: IPaisRepository
    {
        private readonly IConfiguration _configuration;

        public PaisRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Pais entity)
        {
            var sql = "INSERT INTO tblPais (IdPais) VALUES(@IdPais);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idpais)
        {
            var sql = "DELETE FROM tblPais WHERE IdPais = @idpais;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPais = idpais });
                return _affectedRows;
            }
        }
        public async Task<Pais> Get(long idpais)
        {
            var sql = "SELECT IdPais FROM tblPais  WHERE IdPais = @idpais;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Pais>(sql, new { IdPais = idpais });
                Pais _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<Pais>> GetAll()
        {
            var sql = "SELECT IdPais FROM tblPais ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Pais>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Pais entity)
        {
            var sql = "UPDATE tblPais SET IdPais = @idpais WHERE IdPais = @idpais;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPais = entity.IdPais });
                return _affectedRows;
            }
        }
    }
}
