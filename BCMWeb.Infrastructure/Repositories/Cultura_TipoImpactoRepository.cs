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
    public class Cultura_TipoImpactoRepository : ICultura_TipoImpactoRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoImpactoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoImpacto entity)
        {
            var sql = "INSERT INTO tblCultura_TipoImpacto (Culture, IdTipoImpacto, Descripcion) VALUES(@Culture, @IdTipoImpacto, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idtipoimpacto)
        {
            var sql = "DELETE FROM tblCultura_TipoImpacto WHERE Culture = @culture AND IdTipoImpacto = @idtipoimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoImpacto = idtipoimpacto });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoImpacto> Get(string culture, int idtipoimpacto)
        {
            var sql = "SELECT Culture, IdTipoImpacto, Descripcion FROM tblCultura_TipoImpacto  WHERE Culture = @culture AND IdTipoImpacto = @idtipoimpacto;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoImpacto>(sql, new { Culture = culture, IdTipoImpacto = idtipoimpacto });
                Cultura_TipoImpacto _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoImpacto> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoImpacto>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoImpacto, Descripcion FROM tblCultura_TipoImpacto ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoImpacto>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoImpacto entity)
        {
            var sql = "UPDATE tblCultura_TipoImpacto SET Culture = @culture, IdTipoImpacto = @idtipoimpacto, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoImpacto = @idtipoimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoImpacto = entity.IdTipoImpacto });
                return _affectedRows;
            }
        }
    }
}
