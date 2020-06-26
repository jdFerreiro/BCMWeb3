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
    public class PMTProgramacionUsuarioRepository : IPMTProgramacionUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public PMTProgramacionUsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PMTProgramacionUsuario entity)
        {
            var sql = "INSERT INTO tblPMTProgramacionUsuario (IdPMTProgramacion, IdUsuario, IdTipoNotificacion, FechaUltimaNotificacion) VALUES(@IdPMTProgramacion, @IdUsuario, @IdTipoNotificacion, @FechaUltimaNotificacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idpmtprogramacion, long idusuario)
        {
            var sql = "DELETE FROM tblPMTProgramacionUsuario WHERE IdPMTProgramacion = @idpmtprogramacion AND IdUsuario = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPMTProgramacion = idpmtprogramacion, IdUsuario = idusuario });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PMTProgramacionUsuario> Get(long idpmtprogramacion, long idusuario)
        {
            var sql = "SELECT IdPMTProgramacion, IdUsuario, IdTipoNotificacion, FechaUltimaNotificacion FROM tblPMTProgramacionUsuario  WHERE IdPMTProgramacion = @idpmtprogramacion AND IdUsuario = @idusuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacionUsuario>(sql, new { IdPMTProgramacion = idpmtprogramacion, IdUsuario = idusuario });
                PMTProgramacionUsuario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PMTProgramacionUsuario> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PMTProgramacionUsuario>> GetAll()
        {
            var sql = "SELECT IdPMTProgramacion, IdUsuario, IdTipoNotificacion, FechaUltimaNotificacion FROM tblPMTProgramacionUsuario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacionUsuario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PMTProgramacionUsuario entity)
        {
            var sql = "UPDATE tblPMTProgramacionUsuario SET IdPMTProgramacion = @idpmtprogramacion, IdUsuario = @idusuario, IdTipoNotificacion = @idtiponotificacion, FechaUltimaNotificacion = @fechaultimanotificacion WHERE IdPMTProgramacion = @idpmtprogramacion AND IdUsuario = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPMTProgramacion = entity.IdPMTProgramacion, IdUsuario = entity.IdUsuario });
                return _affectedRows;
            }
        }
    }
}
