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
    public class Cultura_CiudadRepository : ICultura_CiudadRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_CiudadRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_Ciudad entity)
        {
            var sql = "INSERT INTO tblCultura_Ciudad (Culture, IdPais, IdEstado, IdCiudad, Nombre) VALUES(@Culture, @IdPais, @IdEstado, @IdCiudad, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idpais, long idestado, long idciudad)
        {
            var sql = "DELETE FROM tblCultura_Ciudad WHERE Culture = @culture AND IdPais = @idpais AND IdEstado = @idestado AND IdCiudad = @idciudad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdPais = idpais, IdEstado = idestado, IdCiudad = idciudad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_Ciudad> Get(string culture, long idpais, long idestado, long idciudad)
        {
            var sql = "SELECT Culture, IdPais, IdEstado, IdCiudad, Nombre FROM tblCultura_Ciudad  WHERE Culture = @culture AND IdPais = @idpais AND IdEstado = @idestado AND IdCiudad = @idciudad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_Ciudad>(sql, new { Culture = culture, IdPais = idpais, IdEstado = idestado, IdCiudad = idciudad });
                Cultura_Ciudad _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_Ciudad> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_Ciudad>> GetAll()
        {
            var sql = "SELECT Culture, IdPais, IdEstado, IdCiudad, Nombre FROM tblCultura_Ciudad ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_Ciudad>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_Ciudad entity)
        {
            var sql = "UPDATE tblCultura_Ciudad SET Culture = @culture, IdPais = @idpais, IdEstado = @idestado, IdCiudad = @idciudad, Nombre = @nombre WHERE Culture = @culture AND IdPais = @idpais AND IdEstado = @idestado AND IdCiudad = @idciudad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdPais = entity.IdPais, IdEstado = entity.IdEstado, IdCiudad = entity.IdCiudad });
                return _affectedRows;
            }
        }
    }
}
