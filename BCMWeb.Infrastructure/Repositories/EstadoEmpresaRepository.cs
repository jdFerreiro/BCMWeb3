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
    public class EstadoEmpresaRepository: IEstadoEmpresaRepository
    {
        private readonly IConfiguration _configuration;

        public EstadoEmpresaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(EstadoEmpresa entity)
        {
            var sql = "INSERT INTO tblEstadoEmpresa (IdEstadoEmpresa) VALUES(@IdEstadoEmpresa);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idestadoempresa)
        {
            var sql = "DELETE FROM tblEstadoEmpresa WHERE IdEstadoEmpresa = @idestadoempresa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstadoEmpresa = idestadoempresa });
                return _affectedRows;
            }
        }
        public async Task<EstadoEmpresa> Get(long idestadoempresa)
        {
            var sql = "SELECT IdEstadoEmpresa FROM tblEstadoEmpresa  WHERE IdEstadoEmpresa = @idestadoempresa;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoEmpresa>(sql, new { IdEstadoEmpresa = idestadoempresa });
                EstadoEmpresa _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<EstadoEmpresa>> GetAll()
        {
            var sql = "SELECT IdEstadoEmpresa FROM tblEstadoEmpresa ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoEmpresa>(sql);
                return _result;
            }

        }
        public async Task<long> Update(EstadoEmpresa entity)
        {
            var sql = "UPDATE tblEstadoEmpresa SET IdEstadoEmpresa = @idestadoempresa WHERE IdEstadoEmpresa = @idestadoempresa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstadoEmpresa = entity.IdEstadoEmpresa });
                return _affectedRows;
            }
        }
    }
}
