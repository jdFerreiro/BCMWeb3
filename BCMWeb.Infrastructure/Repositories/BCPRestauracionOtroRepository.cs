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
    public class BCPRestauracionOtroRepository : IBCPRestauracionOtroRepository
    {
        private readonly IConfiguration _configuration;

        public BCPRestauracionOtroRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPRestauracionOtro entity)
        {
            var sql = "INSERT INTO tblBCPRestauracionOtro (IdEmpresa, IdDocumentoBCP, , Cantidad, Descripcion) VALUES(@IdEmpresa, @IdDocumentoBCP, , @Cantidad, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracionotro)
        {
            var sql = "DELETE FROM tblBCPRestauracionOtro WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRestauracionOtro = @idbcprestauracionotro;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPRestauracionOtro = idbcprestauracionotro });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPRestauracionOtro> Get(long idempresa, long iddocumentobcp, long idbcprestauracionotro)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPRestauracionOtro, Cantidad, Descripcion FROM tblBCPRestauracionOtro  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRestauracionOtro = @idbcprestauracionotro;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRestauracionOtro>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPRestauracionOtro = idbcprestauracionotro });
                BCPRestauracionOtro _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPRestauracionOtro> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPRestauracionOtro>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPRestauracionOtro, Cantidad, Descripcion FROM tblBCPRestauracionOtro ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRestauracionOtro>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPRestauracionOtro entity)
        {
            var sql = "UPDATE tblBCPRestauracionOtro SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, , Cantidad = @cantidad, Descripcion = @descripcion WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPRestauracionOtro = @idbcprestauracionotro;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdBCPRestauracionOtro = entity.IdBCPRestauracionOtro });
                return _affectedRows;
            }
        }
    }
}
