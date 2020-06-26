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
    public class Cultura_NivelImpactoRepository : ICultura_NivelImpactoRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_NivelImpactoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_NivelImpacto entity)
        {
            var sql = "INSERT INTO tblCultura_NivelImpacto (Culture, IdNivelImpacto, Descripcion) VALUES(@Culture, @IdNivelImpacto, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idnivelimpacto)
        {
            var sql = "DELETE FROM tblCultura_NivelImpacto WHERE Culture = @culture AND IdNivelImpacto = @idnivelimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdNivelImpacto = idnivelimpacto });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_NivelImpacto> Get(string culture, int idnivelimpacto)
        {
            var sql = "SELECT Culture, IdNivelImpacto, Descripcion FROM tblCultura_NivelImpacto  WHERE Culture = @culture AND IdNivelImpacto = @idnivelimpacto;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_NivelImpacto>(sql, new { Culture = culture, IdNivelImpacto = idnivelimpacto });
                Cultura_NivelImpacto _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_NivelImpacto> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_NivelImpacto>> GetAll()
        {
            var sql = "SELECT Culture, IdNivelImpacto, Descripcion FROM tblCultura_NivelImpacto ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_NivelImpacto>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_NivelImpacto entity)
        {
            var sql = "UPDATE tblCultura_NivelImpacto SET Culture = @culture, IdNivelImpacto = @idnivelimpacto, Descripcion = @descripcion WHERE Culture = @culture AND IdNivelImpacto = @idnivelimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdNivelImpacto = entity.IdNivelImpacto });
                return _affectedRows;
            }
        }
    }
}
