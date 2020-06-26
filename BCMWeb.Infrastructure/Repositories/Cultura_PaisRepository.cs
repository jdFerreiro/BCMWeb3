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
    public class Cultura_PaisRepository : ICultura_PaisRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_PaisRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_Pais entity)
        {
            var sql = "INSERT INTO tblCultura_Pais (Culture, IdPais, Nombre) VALUES(@Culture, @IdPais, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idpais)
        {
            var sql = "DELETE FROM tblCultura_Pais WHERE Culture = @culture AND IdPais = @idpais;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdPais = idpais });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_Pais> Get(string culture, long idpais)
        {
            var sql = "SELECT Culture, IdPais, Nombre FROM tblCultura_Pais  WHERE Culture = @culture AND IdPais = @idpais;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_Pais>(sql, new { Culture = culture, IdPais = idpais });
                Cultura_Pais _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_Pais> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_Pais>> GetAll()
        {
            var sql = "SELECT Culture, IdPais, Nombre FROM tblCultura_Pais ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_Pais>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_Pais entity)
        {
            var sql = "UPDATE tblCultura_Pais SET Culture = @culture, IdPais = @idpais, Nombre = @nombre WHERE Culture = @culture AND IdPais = @idpais;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdPais = entity.IdPais });
                return _affectedRows;
            }
        }
    }
}
