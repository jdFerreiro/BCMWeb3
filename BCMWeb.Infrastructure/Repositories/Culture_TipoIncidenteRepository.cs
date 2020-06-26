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
    public class Culture_TipoIncidenteRepository : ICulture_TipoIncidenteRepository
    {
        private readonly IConfiguration _configuration;

        public Culture_TipoIncidenteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Culture_TipoIncidente entity)
        {
            var sql = "INSERT INTO tblCulture_TipoIncidente (Culture, IdTipoIncidente, Descripcion) VALUES(@Culture, @IdTipoIncidente, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idtipoincidente)
        {
            var sql = "DELETE FROM tblCulture_TipoIncidente WHERE Culture = @culture AND IdTipoIncidente = @idtipoincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoIncidente = idtipoincidente });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Culture_TipoIncidente> Get(string culture, int idtipoincidente)
        {
            var sql = "SELECT Culture, IdTipoIncidente, Descripcion FROM tblCulture_TipoIncidente  WHERE Culture = @culture AND IdTipoIncidente = @idtipoincidente;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Culture_TipoIncidente>(sql, new { Culture = culture, IdTipoIncidente = idtipoincidente });
                Culture_TipoIncidente _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Culture_TipoIncidente> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Culture_TipoIncidente>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoIncidente, Descripcion FROM tblCulture_TipoIncidente ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Culture_TipoIncidente>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Culture_TipoIncidente entity)
        {
            var sql = "UPDATE tblCulture_TipoIncidente SET Culture = @culture, IdTipoIncidente = @idtipoincidente, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoIncidente = @idtipoincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoIncidente = entity.IdTipoIncidente });
                return _affectedRows;
            }
        }
    }
}
