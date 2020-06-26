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
    public class BIARespaldoSecundarioRepository : IBIARespaldoSecundarioRepository
    {
        private readonly IConfiguration _configuration;

        public BIARespaldoSecundarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIARespaldoSecundario entity)
        {
            var sql = "INSERT INTO tblBIARespaldoSecundario (IdEmpresa, IdDocumentoBIA, IdProceso, , Ubicacion) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Ubicacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrespaldo)
        {
            var sql = "DELETE FROM tblBIARespaldoSecundario WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdRespaldo = @idrespaldo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdRespaldo = idrespaldo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIARespaldoSecundario> Get(long idempresa, long iddocumentobia, long idproceso, long idrespaldo)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdRespaldo, Ubicacion FROM tblBIARespaldoSecundario  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdRespaldo = @idrespaldo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIARespaldoSecundario>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdRespaldo = idrespaldo });
                BIARespaldoSecundario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIARespaldoSecundario> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIARespaldoSecundario>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdRespaldo, Ubicacion FROM tblBIARespaldoSecundario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIARespaldoSecundario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIARespaldoSecundario entity)
        {
            var sql = "UPDATE tblBIARespaldoSecundario SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Ubicacion = @ubicacion WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdRespaldo = @idrespaldo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdRespaldo = entity.IdRespaldo });
                return _affectedRows;
            }
        }
    }
}
