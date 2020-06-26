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
    public class Culture_FuenteIncidenteRepository : ICulture_FuenteIncidenteRepository
    {
        private readonly IConfiguration _configuration;

        public Culture_FuenteIncidenteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Culture_FuenteIncidente entity)
        {
            var sql = "INSERT INTO tblCulture_FuenteIncidente (Culture, IdFuenteIncidente, Descripcion) VALUES(@Culture, @IdFuenteIncidente, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idfuenteincidente)
        {
            var sql = "DELETE FROM tblCulture_FuenteIncidente WHERE Culture = @culture AND IdFuenteIncidente = @idfuenteincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdFuenteIncidente = idfuenteincidente });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Culture_FuenteIncidente> Get(string culture, int idfuenteincidente)
        {
            var sql = "SELECT Culture, IdFuenteIncidente, Descripcion FROM tblCulture_FuenteIncidente  WHERE Culture = @culture AND IdFuenteIncidente = @idfuenteincidente;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Culture_FuenteIncidente>(sql, new { Culture = culture, IdFuenteIncidente = idfuenteincidente });
                Culture_FuenteIncidente _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Culture_FuenteIncidente> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Culture_FuenteIncidente>> GetAll()
        {
            var sql = "SELECT Culture, IdFuenteIncidente, Descripcion FROM tblCulture_FuenteIncidente ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Culture_FuenteIncidente>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Culture_FuenteIncidente entity)
        {
            var sql = "UPDATE tblCulture_FuenteIncidente SET Culture = @culture, IdFuenteIncidente = @idfuenteincidente, Descripcion = @descripcion WHERE Culture = @culture AND IdFuenteIncidente = @idfuenteincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdFuenteIncidente = entity.IdFuenteIncidente });
                return _affectedRows;
            }
        }
    }
}
