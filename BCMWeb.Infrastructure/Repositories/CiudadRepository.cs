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
    public class CiudadRepository : ICiudadRepository
    {
        private readonly IConfiguration _configuration;

        public CiudadRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Ciudad entity)
        {
            var sql = "INSERT INTO tblCiudad (IdPais, IdEstado, IdCiudad) VALUES(@IdPais, @IdEstado, @IdCiudad);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idpais, long idestado, long idciudad)
        {
            var sql = "DELETE FROM tblCiudad WHERE IdPais = @idpais AND IdEstado = @idestado AND IdCiudad = @idciudad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPais = idpais, IdEstado = idestado, IdCiudad = idciudad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Ciudad> Get(long idpais, long idestado, long idciudad)
        {
            var sql = "SELECT IdPais, IdEstado, IdCiudad FROM tblCiudad  WHERE IdPais = @idpais AND IdEstado = @idestado AND IdCiudad = @idciudad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Ciudad>(sql, new { IdPais = idpais, IdEstado = idestado, IdCiudad = idciudad });
                Ciudad _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Ciudad> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Ciudad>> GetAll()
        {
            var sql = "SELECT IdPais, IdEstado, IdCiudad FROM tblCiudad ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Ciudad>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Ciudad entity)
        {
            var sql = "UPDATE tblCiudad SET IdPais = @idpais, IdEstado = @idestado, IdCiudad = @idciudad WHERE IdPais = @idpais AND IdEstado = @idestado AND IdCiudad = @idciudad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPais = entity.IdPais, IdEstado = entity.IdEstado, IdCiudad = entity.IdCiudad });
                return _affectedRows;
            }
        }
    }
}
