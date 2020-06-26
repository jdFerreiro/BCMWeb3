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
    public class TipoRespaldoRepository : ITipoRespaldoRepository
    {
        private readonly IConfiguration _configuration;

        public TipoRespaldoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoRespaldo entity)
        {
            var sql = "INSERT INTO tblTipoRespaldo (IdTipoRespaldo) VALUES(@IdTipoRespaldo);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idtiporespaldo)
        {
            var sql = "DELETE FROM tblTipoRespaldo WHERE IdTipoRespaldo = @idtiporespaldo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoRespaldo = idtiporespaldo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TipoRespaldo> Get(int idtiporespaldo)
        {
            var sql = "SELECT IdTipoRespaldo FROM tblTipoRespaldo  WHERE IdTipoRespaldo = @idtiporespaldo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoRespaldo>(sql, new { IdTipoRespaldo = idtiporespaldo });
                TipoRespaldo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<TipoRespaldo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TipoRespaldo>> GetAll()
        {
            var sql = "SELECT IdTipoRespaldo FROM tblTipoRespaldo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoRespaldo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoRespaldo entity)
        {
            var sql = "UPDATE tblTipoRespaldo SET IdTipoRespaldo = @idtiporespaldo WHERE IdTipoRespaldo = @idtiporespaldo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoRespaldo = entity.IdTipoRespaldo });
                return _affectedRows;
            }
        }
    }
}
