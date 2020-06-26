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
    public class FuenteRiesgoRepository : IFuenteRiesgoRepository
    {
        private readonly IConfiguration _configuration;

        public FuenteRiesgoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(FuenteRiesgo entity)
        {
            var sql = "INSERT INTO tblFuenteRiesgo (IdEmpresa, CodigoFuente, Nombre) VALUES(@IdEmpresa, @CodigoFuente, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, string codigofuente)
        {
            var sql = "DELETE FROM tblFuenteRiesgo WHERE IdEmpresa = @idempresa AND CodigoFuente = @codigofuente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, CodigoFuente = codigofuente });
                return _affectedRows;
            }
        }
        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }
        public async Task<FuenteRiesgo> Get(long idempresa, string codigofuente)
        {
            var sql = "SELECT IdEmpresa, CodigoFuente, Nombre FROM tblFuenteRiesgo  WHERE IdEmpresa = @idempresa AND CodigoFuente = @codigofuente;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<FuenteRiesgo>(sql, new { IdEmpresa = idempresa, CodigoFuente = codigofuente });
                FuenteRiesgo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public Task<FuenteRiesgo> Get(long id)
        {
            throw new System.NotImplementedException();
        }
        public async Task<IEnumerable<FuenteRiesgo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, CodigoFuente, Nombre FROM tblFuenteRiesgo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<FuenteRiesgo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(FuenteRiesgo entity)
        {
            var sql = "UPDATE tblFuenteRiesgo SET IdEmpresa = @idempresa, CodigoFuente = @codigofuente, Nombre = @nombre WHERE IdEmpresa = @idempresa AND CodigoFuente = @codigofuente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, CodigoFuente = entity.CodigoFuente });
                return _affectedRows;
            }
        }
    }
}
