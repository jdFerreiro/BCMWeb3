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
    public class TipoImpactoRepository : ITipoImpactoRepository
    {
        private readonly IConfiguration _configuration;

        public TipoImpactoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoImpacto entity)
        {
            var sql = "INSERT INTO tblTipoImpacto (IdTipoImpacto) VALUES(@IdTipoImpacto);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idtipoimpacto)
        {
            var sql = "DELETE FROM tblTipoImpacto WHERE IdTipoImpacto = @idtipoimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoImpacto = idtipoimpacto });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TipoImpacto> Get(int idtipoimpacto)
        {
            var sql = "SELECT IdTipoImpacto FROM tblTipoImpacto  WHERE IdTipoImpacto = @idtipoimpacto;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoImpacto>(sql, new { IdTipoImpacto = idtipoimpacto });
                TipoImpacto _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<TipoImpacto> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TipoImpacto>> GetAll()
        {
            var sql = "SELECT IdTipoImpacto FROM tblTipoImpacto ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoImpacto>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoImpacto entity)
        {
            var sql = "UPDATE tblTipoImpacto SET IdTipoImpacto = @idtipoimpacto WHERE IdTipoImpacto = @idtipoimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoImpacto = entity.IdTipoImpacto });
                return _affectedRows;
            }
        }
    }
}
