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
    public class TipoTelefonoRepository: ITipoTelefonoRepository
    {
        private readonly IConfiguration _configuration;

        public TipoTelefonoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoTelefono entity)
        {
            var sql = "INSERT INTO tblTipoTelefono (IdTipoTelefono) VALUES(@IdTipoTelefono);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idtipotelefono)
        {
            var sql = "DELETE FROM tblTipoTelefono WHERE IdTipoTelefono = @idtipotelefono;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoTelefono = idtipotelefono });
                return _affectedRows;
            }
        }
        public async Task<TipoTelefono> Get(long idtipotelefono)
        {
            var sql = "SELECT IdTipoTelefono FROM tblTipoTelefono  WHERE IdTipoTelefono = @idtipotelefono;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoTelefono>(sql, new { IdTipoTelefono = idtipotelefono });
                TipoTelefono _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<TipoTelefono>> GetAll()
        {
            var sql = "SELECT IdTipoTelefono FROM tblTipoTelefono ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoTelefono>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoTelefono entity)
        {
            var sql = "UPDATE tblTipoTelefono SET IdTipoTelefono = @idtipotelefono WHERE IdTipoTelefono = @idtipotelefono;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoTelefono = entity.IdTipoTelefono });
                return _affectedRows;
            }
        }
    }
}
