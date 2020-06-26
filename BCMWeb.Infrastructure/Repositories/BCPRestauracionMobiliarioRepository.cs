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
    public class BCPRestauracionMobiliarioRepository : IBCPRestauracionMobiliarioRepository
    {
        private readonly IConfiguration _configuration;

        public BCPRestauracionMobiliarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPRestauracionMobiliario entity)
        {
            var sql = "INSERT INTO tblBCPRestauracionMobiliario (IdEmpresa, IdDocumentoBCP, , Cantidad, Descripcion) VALUES(@IdEmpresa, @IdDocumentoBCP, , @Cantidad, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idrestauracionmobiliario)
        {
            var sql = "DELETE FROM tblBCPRestauracionMobiliario WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdRestauracionMobiliario = @idrestauracionmobiliario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdRestauracionMobiliario = idrestauracionmobiliario });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPRestauracionMobiliario> Get(long idempresa, long iddocumentobcp, long idrestauracionmobiliario)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdRestauracionMobiliario, Cantidad, Descripcion FROM tblBCPRestauracionMobiliario  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdRestauracionMobiliario = @idrestauracionmobiliario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRestauracionMobiliario>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdRestauracionMobiliario = idrestauracionmobiliario });
                BCPRestauracionMobiliario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPRestauracionMobiliario> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPRestauracionMobiliario>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdRestauracionMobiliario, Cantidad, Descripcion FROM tblBCPRestauracionMobiliario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRestauracionMobiliario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPRestauracionMobiliario entity)
        {
            var sql = "UPDATE tblBCPRestauracionMobiliario SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, , Cantidad = @cantidad, Descripcion = @descripcion WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdRestauracionMobiliario = @idrestauracionmobiliario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdRestauracionMobiliario = entity.IdRestauracionMobiliario });
                return _affectedRows;
            }
        }
    }
}
