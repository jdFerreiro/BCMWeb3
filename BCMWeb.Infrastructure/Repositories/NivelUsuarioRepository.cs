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
    public class NivelUsuarioRepository: INivelUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public NivelUsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(NivelUsuario entity)
        {
            var sql = "INSERT INTO tblNivelUsuario (IdNivelUsuario, TodosDocs, RolUsuario) VALUES(@IdNivelUsuario, @TodosDocs, @RolUsuario);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idnivelusuario)
        {
            var sql = "DELETE FROM tblNivelUsuario WHERE IdNivelUsuario = @idnivelusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdNivelUsuario = idnivelusuario });
                return _affectedRows;
            }
        }
        public async Task<NivelUsuario> Get(long idnivelusuario)
        {
            var sql = "SELECT IdNivelUsuario, TodosDocs, RolUsuario FROM tblNivelUsuario  WHERE IdNivelUsuario = @idnivelusuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<NivelUsuario>(sql, new { IdNivelUsuario = idnivelusuario });
                NivelUsuario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<NivelUsuario>> GetAll()
        {
            var sql = "SELECT IdNivelUsuario, TodosDocs, RolUsuario FROM tblNivelUsuario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<NivelUsuario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(NivelUsuario entity)
        {
            var sql = "UPDATE tblNivelUsuario SET IdNivelUsuario = @idnivelusuario, TodosDocs = @todosdocs, RolUsuario = @rolusuario WHERE IdNivelUsuario = @idnivelusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdNivelUsuario = entity.IdNivelUsuario });
                return _affectedRows;
            }
        }
    }
}
