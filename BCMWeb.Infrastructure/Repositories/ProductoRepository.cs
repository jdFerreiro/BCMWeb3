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
    public class ProductoRepository : IProductoRepository
    {
        private readonly IConfiguration _configuration;

        public ProductoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Producto entity)
        {
            var sql = "INSERT INTO tblProducto (IdEmpresa, , Nombre) VALUES(@IdEmpresa, , @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idproducto)
        {
            var sql = "DELETE FROM tblProducto WHERE IdEmpresa = @idempresa AND IdProducto = @idproducto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdProducto = idproducto });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Producto> Get(long idempresa, long idproducto)
        {
            var sql = "SELECT IdEmpresa, IdProducto, Nombre FROM tblProducto  WHERE IdEmpresa = @idempresa AND IdProducto = @idproducto;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Producto>(sql, new { IdEmpresa = idempresa, IdProducto = idproducto });
                Producto _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Producto> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Producto>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdProducto, Nombre FROM tblProducto ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Producto>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Producto entity)
        {
            var sql = "UPDATE tblProducto SET IdEmpresa = @idempresa, , Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdProducto = @idproducto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdProducto = entity.IdProducto });
                return _affectedRows;
            }
        }
    }
}
