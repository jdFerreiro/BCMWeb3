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
    public class BIADocumentacionRepository : IBIADocumentacionRepository
    {
        private readonly IConfiguration _configuration;

        public BIADocumentacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIADocumentacion entity)
        {
            var sql = "INSERT INTO tblBIADocumentacion (IdEmpresa, IdDocumentoBIA, IdProceso, , Nombre, Ubicacion) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Nombre, @Ubicacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long iddocumento)
        {
            var sql = "DELETE FROM tblBIADocumentacion WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdDocumento = @iddocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdDocumento = iddocumento });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIADocumentacion> Get(long idempresa, long iddocumentobia, long idproceso, long iddocumento)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdDocumento, Nombre, Ubicacion FROM tblBIADocumentacion  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdDocumento = @iddocumento;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIADocumentacion>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdDocumento = iddocumento });
                BIADocumentacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIADocumentacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIADocumentacion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdDocumento, Nombre, Ubicacion FROM tblBIADocumentacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIADocumentacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIADocumentacion entity)
        {
            var sql = "UPDATE tblBIADocumentacion SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Nombre = @nombre, Ubicacion = @ubicacion WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdDocumento = @iddocumento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdDocumento = entity.IdDocumento });
                return _affectedRows;
            }
        }
    }
}
