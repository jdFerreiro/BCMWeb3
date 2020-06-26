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
    public class EstadoRiesgoRepository : IEstadoRiesgoRepository
    {
        private readonly IConfiguration _configuration;

        public EstadoRiesgoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(EstadoRiesgo entity)
        {
            var sql = "INSERT INTO tblEstadoRiesgo (IdEmpresa, IdEstadoRiesgo, Nombre, Color) VALUES(@IdEmpresa, @IdEstadoRiesgo, @Nombre, @Color);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, short idestadoriesgo)
        {
            var sql = "DELETE FROM tblEstadoRiesgo WHERE IdEmpresa = @idempresa AND IdEstadoRiesgo = @idestadoriesgo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdEstadoRiesgo = idestadoriesgo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<EstadoRiesgo> Get(long idempresa, short idestadoriesgo)
        {
            var sql = "SELECT IdEmpresa, IdEstadoRiesgo, Nombre, Color FROM tblEstadoRiesgo  WHERE IdEmpresa = @idempresa AND IdEstadoRiesgo = @idestadoriesgo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoRiesgo>(sql, new { IdEmpresa = idempresa, IdEstadoRiesgo = idestadoriesgo });
                EstadoRiesgo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<EstadoRiesgo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<EstadoRiesgo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdEstadoRiesgo, Nombre, Color FROM tblEstadoRiesgo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EstadoRiesgo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(EstadoRiesgo entity)
        {
            var sql = "UPDATE tblEstadoRiesgo SET IdEmpresa = @idempresa, IdEstadoRiesgo = @idestadoriesgo, Nombre = @nombre, Color = @color WHERE IdEmpresa = @idempresa AND IdEstadoRiesgo = @idestadoriesgo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdEstadoRiesgo = entity.IdEstadoRiesgo });
                return _affectedRows;
            }
        }
    }
}
