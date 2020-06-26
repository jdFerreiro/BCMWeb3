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
    public class Cultura_TipoTelefonoRepository : ICultura_TipoTelefonoRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoTelefonoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoTelefono entity)
        {
            var sql = "INSERT INTO tblCultura_TipoTelefono (Culture, IdTipoTelefono, Descripcion) VALUES(@Culture, @IdTipoTelefono, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idtipotelefono)
        {
            var sql = "DELETE FROM tblCultura_TipoTelefono WHERE Culture = @culture AND IdTipoTelefono = @idtipotelefono;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoTelefono = idtipotelefono });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoTelefono> Get(string culture, long idtipotelefono)
        {
            var sql = "SELECT Culture, IdTipoTelefono, Descripcion FROM tblCultura_TipoTelefono  WHERE Culture = @culture AND IdTipoTelefono = @idtipotelefono;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoTelefono>(sql, new { Culture = culture, IdTipoTelefono = idtipotelefono });
                Cultura_TipoTelefono _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoTelefono> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoTelefono>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoTelefono, Descripcion FROM tblCultura_TipoTelefono ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoTelefono>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoTelefono entity)
        {
            var sql = "UPDATE tblCultura_TipoTelefono SET Culture = @culture, IdTipoTelefono = @idtipotelefono, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoTelefono = @idtipotelefono;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoTelefono = entity.IdTipoTelefono });
                return _affectedRows;
            }
        }
    }
}
