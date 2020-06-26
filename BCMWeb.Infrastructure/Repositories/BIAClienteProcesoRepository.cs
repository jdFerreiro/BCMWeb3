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
    public class BIAClienteProcesoRepository : IBIAClienteProcesoRepository
    {
        private readonly IConfiguration _configuration;

        public BIAClienteProcesoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAClienteProceso entity)
        {
            var sql = "INSERT INTO tblBIAClienteProceso (IdEmpresa, IdDocumentoBIA, IdProceso, , Unidad, Responsable, Proceso, Producto) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Unidad, @Responsable, @Proceso, @Producto);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idclienteproceso)
        {
            var sql = "DELETE FROM tblBIAClienteProceso WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdClienteProceso = @idclienteproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdClienteProceso = idclienteproceso });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAClienteProceso> Get(long idempresa, long iddocumentobia, long idproceso, long idclienteproceso)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdClienteProceso, Unidad, Responsable, Proceso, Producto FROM tblBIAClienteProceso  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdClienteProceso = @idclienteproceso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAClienteProceso>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdClienteProceso = idclienteproceso });
                BIAClienteProceso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAClienteProceso> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAClienteProceso>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdClienteProceso, Unidad, Responsable, Proceso, Producto FROM tblBIAClienteProceso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAClienteProceso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAClienteProceso entity)
        {
            var sql = "UPDATE tblBIAClienteProceso SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Unidad = @unidad, Responsable = @responsable, Proceso = @proceso, Producto = @producto WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdClienteProceso = @idclienteproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdClienteProceso = entity.IdClienteProceso });
                return _affectedRows;
            }
        }
    }
}
