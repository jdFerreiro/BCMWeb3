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
    public class TipoCorreoRepository: ITipoCorreoRepository
    {
        private readonly IConfiguration _configuration;

        public TipoCorreoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoCorreo entity)
        {
            var sql = "INSERT INTO tblTipoCorreo (IdTipoCorreo) VALUES(@IdTipoCorreo);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idtipocorreo)
        {
            var sql = "DELETE FROM tblTipoCorreo WHERE IdTipoCorreo = @idtipocorreo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoCorreo = idtipocorreo });
                return _affectedRows;
            }
        }
        public async Task<TipoCorreo> Get(long idtipocorreo)
        {
            var sql = "SELECT IdTipoCorreo FROM tblTipoCorreo  WHERE IdTipoCorreo = @idtipocorreo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoCorreo>(sql, new { IdTipoCorreo = idtipocorreo });
                TipoCorreo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<TipoCorreo>> GetAll()
        {
            var sql = "SELECT IdTipoCorreo FROM tblTipoCorreo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoCorreo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoCorreo entity)
        {
            var sql = "UPDATE tblTipoCorreo SET IdTipoCorreo = @idtipocorreo WHERE IdTipoCorreo = @idtipocorreo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoCorreo = entity.IdTipoCorreo });
                return _affectedRows;
            }
        }
    }
}
