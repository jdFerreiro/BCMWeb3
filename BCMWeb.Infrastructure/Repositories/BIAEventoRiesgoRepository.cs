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
    public class BIAEventoRiesgoRepository : IBIAEventoRiesgoRepository
    {
        private readonly IConfiguration _configuration;

        public BIAEventoRiesgoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAEventoRiesgo entity)
        {
            var sql = "INSERT INTO tblBIAEventoRiesgo (IdEmpresa, Probabilidad, Impacto, Control, Severidad, IdEstadoRiesgo, IdFuenteRiesgo) VALUES(@IdEmpresa, @Probabilidad, @Impacto, @Control, @Severidad, @IdEstadoRiesgo, @IdFuenteRiesgo);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long ideventoriesgo, long idempresa)
        {
            var sql = "DELETE FROM tblBIAEventoRiesgo WHERE IdEventoRiesgo = @ideventoriesgo AND IdEmpresa = @idempresa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEventoRiesgo = ideventoriesgo, IdEmpresa = idempresa });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAEventoRiesgo> Get(long ideventoriesgo, long idempresa)
        {
            var sql = "SELECT IdEventoRiesgo, IdEmpresa, Probabilidad, Impacto, Control, Severidad, IdEstadoRiesgo, IdFuenteRiesgo FROM tblBIAEventoRiesgo  WHERE IdEventoRiesgo = @ideventoriesgo AND IdEmpresa = @idempresa;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAEventoRiesgo>(sql, new { IdEventoRiesgo = ideventoriesgo, IdEmpresa = idempresa });
                BIAEventoRiesgo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAEventoRiesgo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAEventoRiesgo>> GetAll()
        {
            var sql = "SELECT IdEventoRiesgo, IdEmpresa, Probabilidad, Impacto, Control, Severidad, IdEstadoRiesgo, IdFuenteRiesgo FROM tblBIAEventoRiesgo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAEventoRiesgo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAEventoRiesgo entity)
        {
            var sql = "UPDATE tblBIAEventoRiesgo SET IdEmpresa = @idempresa, Probabilidad = @probabilidad, Impacto = @impacto, Control = @control, Severidad = @severidad, IdEstadoRiesgo = @idestadoriesgo, IdFuenteRiesgo = @idfuenteriesgo WHERE IdEventoRiesgo = @ideventoriesgo AND IdEmpresa = @idempresa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEventoRiesgo = entity.IdEventoRiesgo, IdEmpresa = entity.IdEmpresa });
                return _affectedRows;
            }
        }
    }
}
