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
    public class EstadoDocumentoRepository: IEstadoDocumentoRepository
    {
        private readonly IConfiguration _configuration;

        public EstadoDocumentoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(EstadoDocumento entity)
        {
            var sql = "INSERT INTO tblEstadoDocumento (IdEstadoDocumento) VALUES(@IdEstadoDocumento);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idestadodocumento)
        {
            var sql = "DELETE FROM tblEstadoDocumento WHERE IdEstadoDocumento = @idestadodocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstadoDocumento = idestadodocumento });
                return _affectedRows;
            }
        }
        public async Task<EstadoDocumento> Get(long idestadodocumento)
        {
            var sql = "SELECT IdEstadoDocumento FROM tblEstadoDocumento  WHERE IdEstadoDocumento = @idestadodocumento;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoDocumento>(sql, new { IdEstadoDocumento = idestadodocumento });
                EstadoDocumento _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<EstadoDocumento>> GetAll()
        {
            var sql = "SELECT IdEstadoDocumento FROM tblEstadoDocumento ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoDocumento>(sql);
                return _result;
            }

        }
        public async Task<long> Update(EstadoDocumento entity)
        {
            var sql = "UPDATE tblEstadoDocumento SET IdEstadoDocumento = @idestadodocumento WHERE IdEstadoDocumento = @idestadodocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstadoDocumento = entity.IdEstadoDocumento });
                return _affectedRows;
            }
        }
    }
}
