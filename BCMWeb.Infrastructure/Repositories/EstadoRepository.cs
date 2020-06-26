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
    public class EstadoRepository : IEstadoRepository
    {
        private readonly IConfiguration _configuration;

        public EstadoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Estado entity)
        {
            var sql = "INSERT INTO tblEstado (IdPais, IdEstado) VALUES(@IdPais, @IdEstado);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idpais, long idestado)
        {
            var sql = "DELETE FROM tblEstado WHERE IdPais = @idpais AND IdEstado = @idestado;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPais = idpais, IdEstado = idestado });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Estado> Get(long idpais, long idestado)
        {
            var sql = "SELECT IdPais, IdEstado FROM tblEstado  WHERE IdPais = @idpais AND IdEstado = @idestado;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Estado>(sql, new { IdPais = idpais, IdEstado = idestado });
                Estado _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Estado> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Estado>> GetAll()
        {
            var sql = "SELECT IdPais, IdEstado FROM tblEstado ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Estado>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Estado entity)
        {
            var sql = "UPDATE tblEstado SET IdPais = @idpais, IdEstado = @idestado WHERE IdPais = @idpais AND IdEstado = @idestado;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPais = entity.IdPais, IdEstado = entity.IdEstado });
                return _affectedRows;
            }
        }
    }
}
