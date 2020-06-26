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
    public class Cultura_EstadoUsuarioRepository : ICultura_EstadoUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_EstadoUsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_EstadoUsuario entity)
        {
            var sql = "INSERT INTO tblCultura_EstadoUsuario (Culture, IdEstadoUsuario, Descripcion) VALUES(@Culture, @IdEstadoUsuario, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, short idestadousuario)
        {
            var sql = "DELETE FROM tblCultura_EstadoUsuario WHERE Culture = @culture AND IdEstadoUsuario = @idestadousuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdEstadoUsuario = idestadousuario });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_EstadoUsuario> Get(string culture, short idestadousuario)
        {
            var sql = "SELECT Culture, IdEstadoUsuario, Descripcion FROM tblCultura_EstadoUsuario  WHERE Culture = @culture AND IdEstadoUsuario = @idestadousuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_EstadoUsuario>(sql, new { Culture = culture, IdEstadoUsuario = idestadousuario });
                Cultura_EstadoUsuario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_EstadoUsuario> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_EstadoUsuario>> GetAll()
        {
            var sql = "SELECT Culture, IdEstadoUsuario, Descripcion FROM tblCultura_EstadoUsuario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_EstadoUsuario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_EstadoUsuario entity)
        {
            var sql = "UPDATE tblCultura_EstadoUsuario SET Culture = @culture, IdEstadoUsuario = @idestadousuario, Descripcion = @descripcion WHERE Culture = @culture AND IdEstadoUsuario = @idestadousuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdEstadoUsuario = entity.IdEstadoUsuario });
                return _affectedRows;
            }
        }
    }
}
