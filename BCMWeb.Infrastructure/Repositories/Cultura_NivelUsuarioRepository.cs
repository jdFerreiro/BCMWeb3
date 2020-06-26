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
    public class Cultura_NivelUsuarioRepository : ICultura_NivelUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_NivelUsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_NivelUsuario entity)
        {
            var sql = "INSERT INTO tblCultura_NivelUsuario (Culture, IdNivelUsuario, Descripcion) VALUES(@Culture, @IdNivelUsuario, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idnivelusuario)
        {
            var sql = "DELETE FROM tblCultura_NivelUsuario WHERE Culture = @culture AND IdNivelUsuario = @idnivelusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdNivelUsuario = idnivelusuario });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_NivelUsuario> Get(string culture, long idnivelusuario)
        {
            var sql = "SELECT Culture, IdNivelUsuario, Descripcion FROM tblCultura_NivelUsuario  WHERE Culture = @culture AND IdNivelUsuario = @idnivelusuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_NivelUsuario>(sql, new { Culture = culture, IdNivelUsuario = idnivelusuario });
                Cultura_NivelUsuario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_NivelUsuario> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_NivelUsuario>> GetAll()
        {
            var sql = "SELECT Culture, IdNivelUsuario, Descripcion FROM tblCultura_NivelUsuario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_NivelUsuario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_NivelUsuario entity)
        {
            var sql = "UPDATE tblCultura_NivelUsuario SET Culture = @culture, IdNivelUsuario = @idnivelusuario, Descripcion = @descripcion WHERE Culture = @culture AND IdNivelUsuario = @idnivelusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdNivelUsuario = entity.IdNivelUsuario });
                return _affectedRows;
            }
        }
    }
}
