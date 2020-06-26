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
    public class Cultura_TipoCorreoRepository : ICultura_TipoCorreoRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoCorreoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoCorreo entity)
        {
            var sql = "INSERT INTO tblCultura_TipoCorreo (Culture, IdTipoCorreo, Descripcion) VALUES(@Culture, @IdTipoCorreo, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idtipocorreo)
        {
            var sql = "DELETE FROM tblCultura_TipoCorreo WHERE Culture = @culture AND IdTipoCorreo = @idtipocorreo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoCorreo = idtipocorreo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoCorreo> Get(string culture, long idtipocorreo)
        {
            var sql = "SELECT Culture, IdTipoCorreo, Descripcion FROM tblCultura_TipoCorreo  WHERE Culture = @culture AND IdTipoCorreo = @idtipocorreo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoCorreo>(sql, new { Culture = culture, IdTipoCorreo = idtipocorreo });
                Cultura_TipoCorreo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoCorreo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoCorreo>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoCorreo, Descripcion FROM tblCultura_TipoCorreo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoCorreo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoCorreo entity)
        {
            var sql = "UPDATE tblCultura_TipoCorreo SET Culture = @culture, IdTipoCorreo = @idtipocorreo, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoCorreo = @idtipocorreo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoCorreo = entity.IdTipoCorreo });
                return _affectedRows;
            }
        }
    }
}
