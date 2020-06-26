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
    public class Cultura_EstadoEmpresaRepository : ICultura_EstadoEmpresaRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_EstadoEmpresaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_EstadoEmpresa entity)
        {
            var sql = "INSERT INTO tblCultura_EstadoEmpresa (Culture, IdEstadoEmpresa, Descripcion) VALUES(@Culture, @IdEstadoEmpresa, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idestadoempresa)
        {
            var sql = "DELETE FROM tblCultura_EstadoEmpresa WHERE Culture = @culture AND IdEstadoEmpresa = @idestadoempresa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdEstadoEmpresa = idestadoempresa });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_EstadoEmpresa> Get(string culture, long idestadoempresa)
        {
            var sql = "SELECT Culture, IdEstadoEmpresa, Descripcion FROM tblCultura_EstadoEmpresa  WHERE Culture = @culture AND IdEstadoEmpresa = @idestadoempresa;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_EstadoEmpresa>(sql, new { Culture = culture, IdEstadoEmpresa = idestadoempresa });
                Cultura_EstadoEmpresa _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_EstadoEmpresa> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_EstadoEmpresa>> GetAll()
        {
            var sql = "SELECT Culture, IdEstadoEmpresa, Descripcion FROM tblCultura_EstadoEmpresa ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_EstadoEmpresa>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_EstadoEmpresa entity)
        {
            var sql = "UPDATE tblCultura_EstadoEmpresa SET Culture = @culture, IdEstadoEmpresa = @idestadoempresa, Descripcion = @descripcion WHERE Culture = @culture AND IdEstadoEmpresa = @idestadoempresa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdEstadoEmpresa = entity.IdEstadoEmpresa });
                return _affectedRows;
            }
        }
    }
}
