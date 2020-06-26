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
    public class TipoTablaContenidoRepository : ITipoTablaContenidoRepository
    {
        private readonly IConfiguration _configuration;

        public TipoTablaContenidoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoTablaContenido entity)
        {
            var sql = "INSERT INTO tblTipoTablaContenido (IdTipoTablaContenido) VALUES(@IdTipoTablaContenido);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idtipotablacontenido)
        {
            var sql = "DELETE FROM tblTipoTablaContenido WHERE IdTipoTablaContenido = @idtipotablacontenido;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoTablaContenido = idtipotablacontenido });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TipoTablaContenido> Get(int idtipotablacontenido)
        {
            var sql = "SELECT IdTipoTablaContenido FROM tblTipoTablaContenido  WHERE IdTipoTablaContenido = @idtipotablacontenido;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoTablaContenido>(sql, new { IdTipoTablaContenido = idtipotablacontenido });
                TipoTablaContenido _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<TipoTablaContenido> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TipoTablaContenido>> GetAll()
        {
            var sql = "SELECT IdTipoTablaContenido FROM tblTipoTablaContenido ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoTablaContenido>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoTablaContenido entity)
        {
            var sql = "UPDATE tblTipoTablaContenido SET IdTipoTablaContenido = @idtipotablacontenido WHERE IdTipoTablaContenido = @idtipotablacontenido;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoTablaContenido = entity.IdTipoTablaContenido });
                return _affectedRows;
            }
        }
    }
}
