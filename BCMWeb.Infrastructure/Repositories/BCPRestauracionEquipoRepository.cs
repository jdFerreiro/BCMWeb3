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
    public class BCPRestauracionEquipoRepository : IBCPRestauracionEquipoRepository
    {
        private readonly IConfiguration _configuration;

        public BCPRestauracionEquipoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPRestauracionEquipo entity)
        {
            var sql = "INSERT INTO tblBCPRestauracionEquipo (IdEmpresa, IdDocumentoBCP, , Cantidad, Descripcion) VALUES(@IdEmpresa, @IdDocumentoBCP, , @Cantidad, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracionequipo)
        {
            var sql = "DELETE FROM tblBCPRestauracionEquipo WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRestauracionEquipo = @idbcprestauracionequipo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPRestauracionEquipo = idbcprestauracionequipo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPRestauracionEquipo> Get(long idempresa, long iddocumentobcp, long idbcprestauracionequipo)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPRestauracionEquipo, Cantidad, Descripcion FROM tblBCPRestauracionEquipo  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRestauracionEquipo = @idbcprestauracionequipo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRestauracionEquipo>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPRestauracionEquipo = idbcprestauracionequipo });
                BCPRestauracionEquipo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPRestauracionEquipo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPRestauracionEquipo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPRestauracionEquipo, Cantidad, Descripcion FROM tblBCPRestauracionEquipo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRestauracionEquipo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPRestauracionEquipo entity)
        {
            var sql = "UPDATE tblBCPRestauracionEquipo SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, , Cantidad = @cantidad, Descripcion = @descripcion WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRestauracionEquipo = @idbcprestauracionequipo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdBCPRestauracionEquipo = entity.IdBCPRestauracionEquipo });
                return _affectedRows;
            }
        }
    }
}
