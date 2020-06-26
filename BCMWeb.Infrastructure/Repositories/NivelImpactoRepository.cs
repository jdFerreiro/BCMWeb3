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
    public class NivelImpactoRepository : INivelImpactoRepository
    {
        private readonly IConfiguration _configuration;

        public NivelImpactoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(NivelImpacto entity)
        {
            var sql = "INSERT INTO tblNivelImpacto (IdNivelImpacto) VALUES(@IdNivelImpacto);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idnivelimpacto)
        {
            var sql = "DELETE FROM tblNivelImpacto WHERE IdNivelImpacto = @idnivelimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdNivelImpacto = idnivelimpacto });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<NivelImpacto> Get(int idnivelimpacto)
        {
            var sql = "SELECT IdNivelImpacto FROM tblNivelImpacto  WHERE IdNivelImpacto = @idnivelimpacto;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<NivelImpacto>(sql, new { IdNivelImpacto = idnivelimpacto });
                NivelImpacto _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<NivelImpacto> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<NivelImpacto>> GetAll()
        {
            var sql = "SELECT IdNivelImpacto FROM tblNivelImpacto ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<NivelImpacto>(sql);
                return _result;
            }

        }
        public async Task<long> Update(NivelImpacto entity)
        {
            var sql = "UPDATE tblNivelImpacto SET IdNivelImpacto = @idnivelimpacto WHERE IdNivelImpacto = @idnivelimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdNivelImpacto = entity.IdNivelImpacto });
                return _affectedRows;
            }
        }
    }
}
