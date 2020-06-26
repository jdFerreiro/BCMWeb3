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
    public class TipoInterdependenciaRepository : ITipoInterdependenciaRepository
    {
        private readonly IConfiguration _configuration;

        public TipoInterdependenciaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoInterdependencia entity)
        {
            var sql = "INSERT INTO tblTipoInterdependencia (IdTipoInterdependencia) VALUES(@IdTipoInterdependencia);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idtipointerdependencia)
        {
            var sql = "DELETE FROM tblTipoInterdependencia WHERE IdTipoInterdependencia = @idtipointerdependencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoInterdependencia = idtipointerdependencia });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TipoInterdependencia> Get(int idtipointerdependencia)
        {
            var sql = "SELECT IdTipoInterdependencia FROM tblTipoInterdependencia  WHERE IdTipoInterdependencia = @idtipointerdependencia;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoInterdependencia>(sql, new { IdTipoInterdependencia = idtipointerdependencia });
                TipoInterdependencia _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<TipoInterdependencia> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TipoInterdependencia>> GetAll()
        {
            var sql = "SELECT IdTipoInterdependencia FROM tblTipoInterdependencia ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoInterdependencia>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoInterdependencia entity)
        {
            var sql = "UPDATE tblTipoInterdependencia SET IdTipoInterdependencia = @idtipointerdependencia WHERE IdTipoInterdependencia = @idtipointerdependencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoInterdependencia = entity.IdTipoInterdependencia });
                return _affectedRows;
            }
        }
    }
}
