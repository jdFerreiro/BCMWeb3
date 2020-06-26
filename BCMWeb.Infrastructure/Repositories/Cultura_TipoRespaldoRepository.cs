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
    public class Cultura_TipoRespaldoRepository : ICultura_TipoRespaldoRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoRespaldoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoRespaldo entity)
        {
            var sql = "INSERT INTO tblCultura_TipoRespaldo (Culture, IdTipoRespaldo, Descripcion) VALUES(@Culture, @IdTipoRespaldo, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idtiporespaldo)
        {
            var sql = "DELETE FROM tblCultura_TipoRespaldo WHERE Culture = @culture AND IdTipoRespaldo = @idtiporespaldo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoRespaldo = idtiporespaldo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoRespaldo> Get(string culture, int idtiporespaldo)
        {
            var sql = "SELECT Culture, IdTipoRespaldo, Descripcion FROM tblCultura_TipoRespaldo  WHERE Culture = @culture AND IdTipoRespaldo = @idtiporespaldo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoRespaldo>(sql, new { Culture = culture, IdTipoRespaldo = idtiporespaldo });
                Cultura_TipoRespaldo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoRespaldo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoRespaldo>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoRespaldo, Descripcion FROM tblCultura_TipoRespaldo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoRespaldo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoRespaldo entity)
        {
            var sql = "UPDATE tblCultura_TipoRespaldo SET Culture = @culture, IdTipoRespaldo = @idtiporespaldo, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoRespaldo = @idtiporespaldo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoRespaldo = entity.IdTipoRespaldo });
                return _affectedRows;
            }
        }
    }
}
