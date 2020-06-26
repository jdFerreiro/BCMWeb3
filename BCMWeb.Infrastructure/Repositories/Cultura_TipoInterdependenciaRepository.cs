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
    public class Cultura_TipoInterdependenciaRepository : ICultura_TipoInterdependenciaRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoInterdependenciaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoInterdependencia entity)
        {
            var sql = "INSERT INTO tblCultura_TipoInterdependencia (Culture, IdTipoInterdependencia, Descripcion) VALUES(@Culture, @IdTipoInterdependencia, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idtipointerdependencia)
        {
            var sql = "DELETE FROM tblCultura_TipoInterdependencia WHERE Culture = @culture AND IdTipoInterdependencia = @idtipointerdependencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoInterdependencia = idtipointerdependencia });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoInterdependencia> Get(string culture, int idtipointerdependencia)
        {
            var sql = "SELECT Culture, IdTipoInterdependencia, Descripcion FROM tblCultura_TipoInterdependencia  WHERE Culture = @culture AND IdTipoInterdependencia = @idtipointerdependencia;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoInterdependencia>(sql, new { Culture = culture, IdTipoInterdependencia = idtipointerdependencia });
                Cultura_TipoInterdependencia _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoInterdependencia> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoInterdependencia>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoInterdependencia, Descripcion FROM tblCultura_TipoInterdependencia ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoInterdependencia>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoInterdependencia entity)
        {
            var sql = "UPDATE tblCultura_TipoInterdependencia SET Culture = @culture, IdTipoInterdependencia = @idtipointerdependencia, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoInterdependencia = @idtipointerdependencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoInterdependencia = entity.IdTipoInterdependencia });
                return _affectedRows;
            }
        }
    }
}
