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
    public class EmpresaModuloRepository : IEmpresaModuloRepository
    {
        private readonly IConfiguration _configuration;

        public EmpresaModuloRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(EmpresaModulo entity)
        {
            var sql = "INSERT INTO tblEmpresaModulo (IdEmpresa, IdModulo, FechaCreacion) VALUES(@IdEmpresa, @IdModulo, @FechaCreacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idmodulo)
        {
            var sql = "DELETE FROM tblEmpresaModulo WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<EmpresaModulo> Get(long idempresa, long idmodulo)
        {
            var sql = "SELECT IdEmpresa, IdModulo, FechaCreacion FROM tblEmpresaModulo  WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EmpresaModulo>(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo });
                EmpresaModulo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<EmpresaModulo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<EmpresaModulo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdModulo, FechaCreacion FROM tblEmpresaModulo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EmpresaModulo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(EmpresaModulo entity)
        {
            var sql = "UPDATE tblEmpresaModulo SET IdEmpresa = @idempresa, IdModulo = @idmodulo, FechaCreacion = @fechacreacion WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdModulo = entity.IdModulo });
                return _affectedRows;
            }
        }
    }
}
