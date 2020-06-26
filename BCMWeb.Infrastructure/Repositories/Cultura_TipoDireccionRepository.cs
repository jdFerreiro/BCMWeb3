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
    public class Cultura_TipoDireccionRepository : ICultura_TipoDireccionRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoDireccionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoDireccion entity)
        {
            var sql = "INSERT INTO tblCultura_TipoDireccion (Culture, IdTipoDireccion, Descripcion) VALUES(@Culture, @IdTipoDireccion, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idtipodireccion)
        {
            var sql = "DELETE FROM tblCultura_TipoDireccion WHERE Culture = @culture AND IdTipoDireccion = @idtipodireccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoDireccion = idtipodireccion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoDireccion> Get(string culture, long idtipodireccion)
        {
            var sql = "SELECT Culture, IdTipoDireccion, Descripcion FROM tblCultura_TipoDireccion  WHERE Culture = @culture AND IdTipoDireccion = @idtipodireccion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoDireccion>(sql, new { Culture = culture, IdTipoDireccion = idtipodireccion });
                Cultura_TipoDireccion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoDireccion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoDireccion>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoDireccion, Descripcion FROM tblCultura_TipoDireccion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoDireccion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoDireccion entity)
        {
            var sql = "UPDATE tblCultura_TipoDireccion SET Culture = @culture, IdTipoDireccion = @idtipodireccion, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoDireccion = @idtipodireccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoDireccion = entity.IdTipoDireccion });
                return _affectedRows;
            }
        }
    }
}
