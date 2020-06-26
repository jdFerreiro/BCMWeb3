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
    public class Cultura_TipoResultadoPruebaRepository : ICultura_TipoResultadoPruebaRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoResultadoPruebaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoResultadoPrueba entity)
        {
            var sql = "INSERT INTO tblCultura_TipoResultadoPrueba (Culture, IdTipoResultadoPrueba, Descripcion) VALUES(@Culture, @IdTipoResultadoPrueba, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idtiporesultadoprueba)
        {
            var sql = "DELETE FROM tblCultura_TipoResultadoPrueba WHERE Culture = @culture AND IdTipoResultadoPrueba = @idtiporesultadoprueba;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoResultadoPrueba = idtiporesultadoprueba });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoResultadoPrueba> Get(string culture, int idtiporesultadoprueba)
        {
            var sql = "SELECT Culture, IdTipoResultadoPrueba, Descripcion FROM tblCultura_TipoResultadoPrueba  WHERE Culture = @culture AND IdTipoResultadoPrueba = @idtiporesultadoprueba;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoResultadoPrueba>(sql, new { Culture = culture, IdTipoResultadoPrueba = idtiporesultadoprueba });
                Cultura_TipoResultadoPrueba _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoResultadoPrueba> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoResultadoPrueba>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoResultadoPrueba, Descripcion FROM tblCultura_TipoResultadoPrueba ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoResultadoPrueba>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoResultadoPrueba entity)
        {
            var sql = "UPDATE tblCultura_TipoResultadoPrueba SET Culture = @culture, IdTipoResultadoPrueba = @idtiporesultadoprueba, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoResultadoPrueba = @idtiporesultadoprueba;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoResultadoPrueba = entity.IdTipoResultadoPrueba });
                return _affectedRows;
            }
        }
    }
}
