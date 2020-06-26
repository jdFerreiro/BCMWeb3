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
    public class Cultura_EstadoRepository : ICultura_EstadoRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_EstadoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_Estado entity)
        {
            var sql = "INSERT INTO tblCultura_Estado (Culture, IdPais, IdEstado, Nombre) VALUES(@Culture, @IdPais, @IdEstado, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idpais, long idestado)
        {
            var sql = "DELETE FROM tblCultura_Estado WHERE Culture = @culture AND IdPais = @idpais AND IdEstado = @idestado;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdPais = idpais, IdEstado = idestado });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_Estado> Get(string culture, long idpais, long idestado)
        {
            var sql = "SELECT Culture, IdPais, IdEstado, Nombre FROM tblCultura_Estado  WHERE Culture = @culture AND IdPais = @idpais AND IdEstado = @idestado;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_Estado>(sql, new { Culture = culture, IdPais = idpais, IdEstado = idestado });
                Cultura_Estado _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_Estado> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_Estado>> GetAll()
        {
            var sql = "SELECT Culture, IdPais, IdEstado, Nombre FROM tblCultura_Estado ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_Estado>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_Estado entity)
        {
            var sql = "UPDATE tblCultura_Estado SET Culture = @culture, IdPais = @idpais, IdEstado = @idestado, Nombre = @nombre WHERE Culture = @culture AND IdPais = @idpais AND IdEstado = @idestado;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdPais = entity.IdPais, IdEstado = entity.IdEstado });
                return _affectedRows;
            }
        }
    }
}
