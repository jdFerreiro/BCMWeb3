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
    public class TipoIncidenteRepository : ITipoIncidenteRepository
    {
        private readonly IConfiguration _configuration;

        public TipoIncidenteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoIncidente entity)
        {
            var sql = "INSERT INTO tblTipoIncidente () VALUES();";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idtipoincidente)
        {
            var sql = "DELETE FROM tblTipoIncidente WHERE IdTipoIncidente = @idtipoincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoIncidente = idtipoincidente });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TipoIncidente> Get(int idtipoincidente)
        {
            var sql = "SELECT IdTipoIncidente FROM tblTipoIncidente  WHERE IdTipoIncidente = @idtipoincidente;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoIncidente>(sql, new { IdTipoIncidente = idtipoincidente });
                TipoIncidente _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<TipoIncidente> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TipoIncidente>> GetAll()
        {
            var sql = "SELECT IdTipoIncidente FROM tblTipoIncidente ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoIncidente>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoIncidente entity)
        {
            var sql = "UPDATE tblTipoIncidente SET  WHERE IdTipoIncidente = @idtipoincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoIncidente = entity.IdTipoIncidente });
                return _affectedRows;
            }
        }
    }
}
