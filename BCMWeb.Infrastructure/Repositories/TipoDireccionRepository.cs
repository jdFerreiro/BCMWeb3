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
    public class TipoDireccionRepository: ITipoDireccionRepository
    {
        private readonly IConfiguration _configuration;

        public TipoDireccionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoDireccion entity)
        {
            var sql = "INSERT INTO tblTipoDireccion (IdTipoDireccion) VALUES(@IdTipoDireccion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idtipodireccion)
        {
            var sql = "DELETE FROM tblTipoDireccion WHERE IdTipoDireccion = @idtipodireccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoDireccion = idtipodireccion });
                return _affectedRows;
            }
        }
        public async Task<TipoDireccion> Get(long idtipodireccion)
        {
            var sql = "SELECT IdTipoDireccion FROM tblTipoDireccion  WHERE IdTipoDireccion = @idtipodireccion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoDireccion>(sql, new { IdTipoDireccion = idtipodireccion });
                TipoDireccion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<TipoDireccion>> GetAll()
        {
            var sql = "SELECT IdTipoDireccion FROM tblTipoDireccion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoDireccion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoDireccion entity)
        {
            var sql = "UPDATE tblTipoDireccion SET IdTipoDireccion = @idtipodireccion WHERE IdTipoDireccion = @idtipodireccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoDireccion = entity.IdTipoDireccion });
                return _affectedRows;
            }
        }
    }
}
