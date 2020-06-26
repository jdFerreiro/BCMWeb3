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
    public class Cultura_TipoTablaContenidoRepository : ICultura_TipoTablaContenidoRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoTablaContenidoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoTablaContenido entity)
        {
            var sql = "INSERT INTO tblCultura_TipoTablaContenido (Culture, IdTipoTablaContenido, Descripcion) VALUES(@Culture, @IdTipoTablaContenido, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idtipotablacontenido)
        {
            var sql = "DELETE FROM tblCultura_TipoTablaContenido WHERE Culture = @culture AND IdTipoTablaContenido = @idtipotablacontenido;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoTablaContenido = idtipotablacontenido });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoTablaContenido> Get(string culture, int idtipotablacontenido)
        {
            var sql = "SELECT Culture, IdTipoTablaContenido, Descripcion FROM tblCultura_TipoTablaContenido  WHERE Culture = @culture AND IdTipoTablaContenido = @idtipotablacontenido;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoTablaContenido>(sql, new { Culture = culture, IdTipoTablaContenido = idtipotablacontenido });
                Cultura_TipoTablaContenido _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoTablaContenido> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoTablaContenido>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoTablaContenido, Descripcion FROM tblCultura_TipoTablaContenido ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoTablaContenido>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoTablaContenido entity)
        {
            var sql = "UPDATE tblCultura_TipoTablaContenido SET Culture = @culture, IdTipoTablaContenido = @idtipotablacontenido, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoTablaContenido = @idtipotablacontenido;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoTablaContenido = entity.IdTipoTablaContenido });
                return _affectedRows;
            }
        }
    }
}
