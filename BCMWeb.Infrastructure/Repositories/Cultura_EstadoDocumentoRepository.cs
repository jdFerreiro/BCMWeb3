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
    public class Cultura_EstadoDocumentoRepository : ICultura_EstadoDocumentoRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_EstadoDocumentoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_EstadoDocumento entity)
        {
            var sql = "INSERT INTO tblCultura_EstadoDocumento (Culture, IdEstadoDocumento, Descripcion) VALUES(@Culture, @IdEstadoDocumento, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idestadodocumento)
        {
            var sql = "DELETE FROM tblCultura_EstadoDocumento WHERE Culture = @culture AND IdEstadoDocumento = @idestadodocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdEstadoDocumento = idestadodocumento });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_EstadoDocumento> Get(string culture, long idestadodocumento)
        {
            var sql = "SELECT Culture, IdEstadoDocumento, Descripcion FROM tblCultura_EstadoDocumento  WHERE Culture = @culture AND IdEstadoDocumento = @idestadodocumento;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_EstadoDocumento>(sql, new { Culture = culture, IdEstadoDocumento = idestadodocumento });
                Cultura_EstadoDocumento _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_EstadoDocumento> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_EstadoDocumento>> GetAll()
        {
            var sql = "SELECT Culture, IdEstadoDocumento, Descripcion FROM tblCultura_EstadoDocumento ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_EstadoDocumento>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_EstadoDocumento entity)
        {
            var sql = "UPDATE tblCultura_EstadoDocumento SET Culture = @culture, IdEstadoDocumento = @idestadodocumento, Descripcion = @descripcion WHERE Culture = @culture AND IdEstadoDocumento = @idestadodocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdEstadoDocumento = entity.IdEstadoDocumento });
                return _affectedRows;
            }
        }
    }
}
