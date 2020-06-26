using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class EstadoUsuarioRepository : IEstadoUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public EstadoUsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(EstadoUsuario entity)
        {
            var sql = "INSERT INTO tblEstadoUsuario (IdEstadoUsuario) VALUES(@IdEstadoUsuario);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(short idestadousuario)
        {
            var sql = "DELETE FROM tblEstadoUsuario WHERE IdEstadoUsuario = @idestadousuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstadoUsuario = idestadousuario });
                return _affectedRows;
            }
        }
        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }
        public async Task<EstadoUsuario> Get(short idestadousuario)
        {
            var sql = "SELECT IdEstadoUsuario FROM tblEstadoUsuario  WHERE IdEstadoUsuario = @idestadousuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoUsuario>(sql, new { IdEstadoUsuario = idestadousuario });
                EstadoUsuario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public Task<EstadoUsuario> Get(long id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<EstadoUsuario>> GetAll()
        {
            var sql = "SELECT IdEstadoUsuario FROM tblEstadoUsuario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoUsuario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(EstadoUsuario entity)
        {
            var sql = "UPDATE tblEstadoUsuario SET IdEstadoUsuario = @idestadousuario WHERE IdEstadoUsuario = @idestadousuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstadoUsuario = entity.IdEstadoUsuario });
                return _affectedRows;
            }
        }
    }
}
