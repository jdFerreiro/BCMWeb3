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
    public class Cultura_EstadoProcesoRepository : ICultura_EstadoProcesoRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_EstadoProcesoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_EstadoProceso entity)
        {
            var sql = "INSERT INTO tblCultura_EstadoProceso (Culture, IdEstadoProceso, Descripcion) VALUES(@Culture, @IdEstadoProceso, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idestadoproceso)
        {
            var sql = "DELETE FROM tblCultura_EstadoProceso WHERE Culture = @culture AND IdEstadoProceso = @idestadoproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdEstadoProceso = idestadoproceso });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_EstadoProceso> Get(string culture, long idestadoproceso)
        {
            var sql = "SELECT Culture, IdEstadoProceso, Descripcion FROM tblCultura_EstadoProceso  WHERE Culture = @culture AND IdEstadoProceso = @idestadoproceso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_EstadoProceso>(sql, new { Culture = culture, IdEstadoProceso = idestadoproceso });
                Cultura_EstadoProceso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_EstadoProceso> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_EstadoProceso>> GetAll()
        {
            var sql = "SELECT Culture, IdEstadoProceso, Descripcion FROM tblCultura_EstadoProceso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_EstadoProceso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_EstadoProceso entity)
        {
            var sql = "UPDATE tblCultura_EstadoProceso SET Culture = @culture, IdEstadoProceso = @idestadoproceso, Descripcion = @descripcion WHERE Culture = @culture AND IdEstadoProceso = @idestadoproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdEstadoProceso = entity.IdEstadoProceso });
                return _affectedRows;
            }
        }
    }
}
