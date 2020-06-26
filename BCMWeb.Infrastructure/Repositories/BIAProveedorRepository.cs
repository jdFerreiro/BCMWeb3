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
    public class BIAProveedorRepository : IBIAProveedorRepository
    {
        private readonly IConfiguration _configuration;

        public BIAProveedorRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAProveedor entity)
        {
            var sql = "INSERT INTO tblBIAProveedor (IdEmpresa, IdDocumentoBIA, IdProceso, , Organizacion, Servicio, Contacto) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Organizacion, @Servicio, @Contacto);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idproveedor)
        {
            var sql = "DELETE FROM tblBIAProveedor WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdProveedor = @idproveedor;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdProveedor = idproveedor });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAProveedor> Get(long idempresa, long iddocumentobia, long idproceso, long idproveedor)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdProveedor, Organizacion, Servicio, Contacto FROM tblBIAProveedor  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdProveedor = @idproveedor;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAProveedor>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdProveedor = idproveedor });
                BIAProveedor _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAProveedor> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAProveedor>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdProveedor, Organizacion, Servicio, Contacto FROM tblBIAProveedor ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAProveedor>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAProveedor entity)
        {
            var sql = "UPDATE tblBIAProveedor SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Organizacion = @organizacion, Servicio = @servicio, Contacto = @contacto WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdProveedor = @idproveedor;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdProveedor = entity.IdProveedor });
                return _affectedRows;
            }
        }
    }
}
