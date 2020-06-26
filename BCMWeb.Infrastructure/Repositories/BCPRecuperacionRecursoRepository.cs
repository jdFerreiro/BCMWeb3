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
    public class BCPRecuperacionRecursoRepository : IBCPRecuperacionRecursoRepository
    {
        private readonly IConfiguration _configuration;

        public BCPRecuperacionRecursoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPRecuperacionRecurso entity)
        {
            var sql = "INSERT INTO tblBCPRecuperacionRecurso (IdEmpresa, IdDocumentoBCP, , Cantidad, Nombre) VALUES(@IdEmpresa, @IdDocumentoBCP, , @Cantidad, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idrecuperacionrecurso)
        {
            var sql = "DELETE FROM tblBCPRecuperacionRecurso WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdRecuperacionRecurso = @idrecuperacionrecurso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdRecuperacionRecurso = idrecuperacionrecurso });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPRecuperacionRecurso> Get(long idempresa, long iddocumentobcp, long idrecuperacionrecurso)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdRecuperacionRecurso, Cantidad, Nombre FROM tblBCPRecuperacionRecurso  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdRecuperacionRecurso = @idrecuperacionrecurso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRecuperacionRecurso>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdRecuperacionRecurso = idrecuperacionrecurso });
                BCPRecuperacionRecurso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPRecuperacionRecurso> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPRecuperacionRecurso>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdRecuperacionRecurso, Cantidad, Nombre FROM tblBCPRecuperacionRecurso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPRecuperacionRecurso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPRecuperacionRecurso entity)
        {
            var sql = "UPDATE tblBCPRecuperacionRecurso SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, , Cantidad = @cantidad, Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdRecuperacionRecurso = @idrecuperacionrecurso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdRecuperacionRecurso = entity.IdRecuperacionRecurso });
                return _affectedRows;
            }
        }
    }
}
