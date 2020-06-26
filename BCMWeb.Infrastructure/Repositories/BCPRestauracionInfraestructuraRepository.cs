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
    public class BCPRestauracionInfraestructuraRepository : IBCPRestauracionInfraestructuraRepository
    {
        private readonly IConfiguration _configuration;

        public BCPRestauracionInfraestructuraRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPRestauracionInfraestructura entity)
        {
            var sql = "INSERT INTO tblBCPRestauracionInfraestructura (IdEmpresa, IdDocumentoBCP, , Cantidad, Descripcion) VALUES(@IdEmpresa, @IdDocumentoBCP, , @Cantidad, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracioninfraestructura)
        {
            var sql = "DELETE FROM tblBCPRestauracionInfraestructura WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRestauracionInfraestructura = @idbcprestauracioninfraestructura;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPRestauracionInfraestructura = idbcprestauracioninfraestructura });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPRestauracionInfraestructura> Get(long idempresa, long iddocumentobcp, long idbcprestauracioninfraestructura)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPRestauracionInfraestructura, Cantidad, Descripcion FROM tblBCPRestauracionInfraestructura  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRestauracionInfraestructura = @idbcprestauracioninfraestructura;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRestauracionInfraestructura>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPRestauracionInfraestructura = idbcprestauracioninfraestructura });
                BCPRestauracionInfraestructura _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPRestauracionInfraestructura> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPRestauracionInfraestructura>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPRestauracionInfraestructura, Cantidad, Descripcion FROM tblBCPRestauracionInfraestructura ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRestauracionInfraestructura>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPRestauracionInfraestructura entity)
        {
            var sql = "UPDATE tblBCPRestauracionInfraestructura SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, , Cantidad = @cantidad, Descripcion = @descripcion WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRestauracionInfraestructura = @idbcprestauracioninfraestructura;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdBCPRestauracionInfraestructura = entity.IdBCPRestauracionInfraestructura });
                return _affectedRows;
            }
        }
    }
}
