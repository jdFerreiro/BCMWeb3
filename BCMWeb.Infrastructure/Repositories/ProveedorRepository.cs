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
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly IConfiguration _configuration;

        public ProveedorRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Proveedor entity)
        {
            var sql = "INSERT INTO tblProveedor (IdEmpresa, , Nombre) VALUES(@IdEmpresa, , @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idproveedor)
        {
            var sql = "DELETE FROM tblProveedor WHERE IdEmpresa = @idempresa AND IdProveedor = @idproveedor;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdProveedor = idproveedor });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Proveedor> Get(long idempresa, long idproveedor)
        {
            var sql = "SELECT IdEmpresa, IdProveedor, Nombre FROM tblProveedor  WHERE IdEmpresa = @idempresa AND IdProveedor = @idproveedor;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Proveedor>(sql, new { IdEmpresa = idempresa, IdProveedor = idproveedor });
                Proveedor _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Proveedor> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Proveedor>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdProveedor, Nombre FROM tblProveedor ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Proveedor>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Proveedor entity)
        {
            var sql = "UPDATE tblProveedor SET IdEmpresa = @idempresa, , Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdProveedor = @idproveedor;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdProveedor = entity.IdProveedor });
                return _affectedRows;
            }
        }

        Task<long> IProveedorRepository.Delete(long idempresa, long idproveedor)
        {
            throw new System.NotImplementedException();
        }
    }
}
