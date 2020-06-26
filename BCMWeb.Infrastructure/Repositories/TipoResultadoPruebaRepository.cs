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
    public class TipoResultadoPruebaRepository : ITipoResultadoPruebaRepository
    {
        private readonly IConfiguration _configuration;

        public TipoResultadoPruebaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoResultadoPrueba entity)
        {
            var sql = "INSERT INTO tblTipoResultadoPrueba (IdTipoResultadoPrueba) VALUES(@IdTipoResultadoPrueba);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idtiporesultadoprueba)
        {
            var sql = "DELETE FROM tblTipoResultadoPrueba WHERE IdTipoResultadoPrueba = @idtiporesultadoprueba;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoResultadoPrueba = idtiporesultadoprueba });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TipoResultadoPrueba> Get(int idtiporesultadoprueba)
        {
            var sql = "SELECT IdTipoResultadoPrueba FROM tblTipoResultadoPrueba  WHERE IdTipoResultadoPrueba = @idtiporesultadoprueba;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoResultadoPrueba>(sql, new { IdTipoResultadoPrueba = idtiporesultadoprueba });
                TipoResultadoPrueba _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<TipoResultadoPrueba> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TipoResultadoPrueba>> GetAll()
        {
            var sql = "SELECT IdTipoResultadoPrueba FROM tblTipoResultadoPrueba ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoResultadoPrueba>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoResultadoPrueba entity)
        {
            var sql = "UPDATE tblTipoResultadoPrueba SET IdTipoResultadoPrueba = @idtiporesultadoprueba WHERE IdTipoResultadoPrueba = @idtiporesultadoprueba;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoResultadoPrueba = entity.IdTipoResultadoPrueba });
                return _affectedRows;
            }
        }
    }
}
