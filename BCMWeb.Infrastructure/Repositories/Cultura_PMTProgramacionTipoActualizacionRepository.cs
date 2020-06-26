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
    public class Cultura_PMTProgramacionTipoActualizacionRepository : ICultura_PMTProgramacionTipoActualizacionRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_PMTProgramacionTipoActualizacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_PMTProgramacionTipoActualizacion entity)
        {
            var sql = "INSERT INTO tblCultura_PMTProgramacionTipoActualizacion (Culture, IdTipoActualizacion, Descripcion) VALUES(@Culture, @IdTipoActualizacion, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, short idtipoactualizacion)
        {
            var sql = "DELETE FROM tblCultura_PMTProgramacionTipoActualizacion WHERE Culture = @culture AND IdTipoActualizacion = @idtipoactualizacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoActualizacion = idtipoactualizacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_PMTProgramacionTipoActualizacion> Get(string culture, short idtipoactualizacion)
        {
            var sql = "SELECT Culture, IdTipoActualizacion, Descripcion FROM tblCultura_PMTProgramacionTipoActualizacion  WHERE Culture = @culture AND IdTipoActualizacion = @idtipoactualizacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_PMTProgramacionTipoActualizacion>(sql, new { Culture = culture, IdTipoActualizacion = idtipoactualizacion });
                Cultura_PMTProgramacionTipoActualizacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_PMTProgramacionTipoActualizacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_PMTProgramacionTipoActualizacion>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoActualizacion, Descripcion FROM tblCultura_PMTProgramacionTipoActualizacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_PMTProgramacionTipoActualizacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_PMTProgramacionTipoActualizacion entity)
        {
            var sql = "UPDATE tblCultura_PMTProgramacionTipoActualizacion SET Culture = @culture, IdTipoActualizacion = @idtipoactualizacion, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoActualizacion = @idtipoactualizacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoActualizacion = entity.IdTipoActualizacion });
                return _affectedRows;
            }
        }
    }
}
