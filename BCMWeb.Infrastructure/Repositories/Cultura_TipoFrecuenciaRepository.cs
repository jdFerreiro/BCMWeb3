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
    public class Cultura_TipoFrecuenciaRepository : ICultura_TipoFrecuenciaRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoFrecuenciaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoFrecuencia entity)
        {
            var sql = "INSERT INTO tblCultura_TipoFrecuencia (Culture, IdTipoFrecuencia, Descripcion) VALUES(@Culture, @IdTipoFrecuencia, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, long idtipofrecuencia)
        {
            var sql = "DELETE FROM tblCultura_TipoFrecuencia WHERE Culture = @culture AND IdTipoFrecuencia = @idtipofrecuencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoFrecuencia = idtipofrecuencia });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoFrecuencia> Get(string culture, long idtipofrecuencia)
        {
            var sql = "SELECT Culture, IdTipoFrecuencia, Descripcion FROM tblCultura_TipoFrecuencia  WHERE Culture = @culture AND IdTipoFrecuencia = @idtipofrecuencia;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoFrecuencia>(sql, new { Culture = culture, IdTipoFrecuencia = idtipofrecuencia });
                Cultura_TipoFrecuencia _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoFrecuencia> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoFrecuencia>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoFrecuencia, Descripcion FROM tblCultura_TipoFrecuencia ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoFrecuencia>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoFrecuencia entity)
        {
            var sql = "UPDATE tblCultura_TipoFrecuencia SET Culture = @culture, IdTipoFrecuencia = @idtipofrecuencia, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoFrecuencia = @idtipofrecuencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoFrecuencia = entity.IdTipoFrecuencia });
                return _affectedRows;
            }
        }
    }
}
