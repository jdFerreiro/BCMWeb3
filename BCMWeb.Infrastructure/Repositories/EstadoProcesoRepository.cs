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
    public class EstadoProcesoRepository: IEstadoProcesoRepository
    {
        private readonly IConfiguration _configuration;

        public EstadoProcesoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(EstadoProceso entity)
        {
            var sql = "INSERT INTO tblEstadoProceso (IdEstadoProceso) VALUES(@IdEstadoProceso);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idestadoproceso)
        {
            var sql = "DELETE FROM tblEstadoProceso WHERE IdEstadoProceso = @idestadoproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstadoProceso = idestadoproceso });
                return _affectedRows;
            }
        }
        public async Task<EstadoProceso> Get(long idestadoproceso)
        {
            var sql = "SELECT IdEstadoProceso FROM tblEstadoProceso  WHERE IdEstadoProceso = @idestadoproceso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoProceso>(sql, new { IdEstadoProceso = idestadoproceso });
                EstadoProceso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<EstadoProceso>> GetAll()
        {
            var sql = "SELECT IdEstadoProceso FROM tblEstadoProceso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoProceso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(EstadoProceso entity)
        {
            var sql = "UPDATE tblEstadoProceso SET IdEstadoProceso = @idestadoproceso WHERE IdEstadoProceso = @idestadoproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEstadoProceso = entity.IdEstadoProceso });
                return _affectedRows;
            }
        }
    }
}
