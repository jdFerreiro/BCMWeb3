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
    public class Cultura_PMTProgramacionTipoNotificacionRepository : ICultura_PMTProgramacionTipoNotificacionRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_PMTProgramacionTipoNotificacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_PMTProgramacionTipoNotificacion entity)
        {
            var sql = "INSERT INTO tblCultura_PMTProgramacionTipoNotificacion (Cultura, IdTipoNotificacion, Descripcion) VALUES(@Cultura, @IdTipoNotificacion, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string cultura, short idtiponotificacion)
        {
            var sql = "DELETE FROM tblCultura_PMTProgramacionTipoNotificacion WHERE Cultura = @cultura AND IdTipoNotificacion = @idtiponotificacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Cultura = cultura, IdTipoNotificacion = idtiponotificacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_PMTProgramacionTipoNotificacion> Get(string cultura, short idtiponotificacion)
        {
            var sql = "SELECT Cultura, IdTipoNotificacion, Descripcion FROM tblCultura_PMTProgramacionTipoNotificacion  WHERE Cultura = @cultura AND IdTipoNotificacion = @idtiponotificacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_PMTProgramacionTipoNotificacion>(sql, new { Cultura = cultura, IdTipoNotificacion = idtiponotificacion });
                Cultura_PMTProgramacionTipoNotificacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_PMTProgramacionTipoNotificacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_PMTProgramacionTipoNotificacion>> GetAll()
        {
            var sql = "SELECT Cultura, IdTipoNotificacion, Descripcion FROM tblCultura_PMTProgramacionTipoNotificacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_PMTProgramacionTipoNotificacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_PMTProgramacionTipoNotificacion entity)
        {
            var sql = "UPDATE tblCultura_PMTProgramacionTipoNotificacion SET Cultura = @cultura, IdTipoNotificacion = @idtiponotificacion, Descripcion = @descripcion WHERE Cultura = @cultura AND IdTipoNotificacion = @idtiponotificacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Cultura = entity.Cultura, IdTipoNotificacion = entity.IdTipoNotificacion });
                return _affectedRows;
            }
        }
    }
}
