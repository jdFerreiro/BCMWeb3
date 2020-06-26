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
    public class Cultura_MesRepository : ICultura_MesRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_MesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_Mes entity)
        {
            var sql = "INSERT INTO tblCultura_Mes (Culture, IdMes, Descripcion) VALUES(@Culture, @IdMes, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idmes)
        {
            var sql = "DELETE FROM tblCultura_Mes WHERE Culture = @culture AND IdMes = @idmes;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdMes = idmes });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_Mes> Get(string culture, int idmes)
        {
            var sql = "SELECT Culture, IdMes, Descripcion FROM tblCultura_Mes  WHERE Culture = @culture AND IdMes = @idmes;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_Mes>(sql, new { Culture = culture, IdMes = idmes });
                Cultura_Mes _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_Mes> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_Mes>> GetAll()
        {
            var sql = "SELECT Culture, IdMes, Descripcion FROM tblCultura_Mes ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_Mes>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_Mes entity)
        {
            var sql = "UPDATE tblCultura_Mes SET Culture = @culture, IdMes = @idmes, Descripcion = @descripcion WHERE Culture = @culture AND IdMes = @idmes;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdMes = entity.IdMes });
                return _affectedRows;
            }
        }
    }
}
