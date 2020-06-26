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
    public class Cultura_PBEPruebaEstatusRepository : ICultura_PBEPruebaEstatusRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_PBEPruebaEstatusRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_PBEPruebaEstatus entity)
        {
            var sql = "INSERT INTO tblCultura_PBEPruebaEstatus (Cultura, IdEstatus, Descripcion) VALUES(@Cultura, @IdEstatus, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string cultura, short idestatus)
        {
            var sql = "DELETE FROM tblCultura_PBEPruebaEstatus WHERE Cultura = @cultura AND IdEstatus = @idestatus;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Cultura = cultura, IdEstatus = idestatus });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_PBEPruebaEstatus> Get(string cultura, short idestatus)
        {
            var sql = "SELECT Cultura, IdEstatus, Descripcion FROM tblCultura_PBEPruebaEstatus  WHERE Cultura = @cultura AND IdEstatus = @idestatus;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_PBEPruebaEstatus>(sql, new { Cultura = cultura, IdEstatus = idestatus });
                Cultura_PBEPruebaEstatus _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_PBEPruebaEstatus> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_PBEPruebaEstatus>> GetAll()
        {
            var sql = "SELECT Cultura, IdEstatus, Descripcion FROM tblCultura_PBEPruebaEstatus ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_PBEPruebaEstatus>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_PBEPruebaEstatus entity)
        {
            var sql = "UPDATE tblCultura_PBEPruebaEstatus SET Cultura = @cultura, IdEstatus = @idestatus, Descripcion = @descripcion WHERE Cultura = @cultura AND IdEstatus = @idestatus;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Cultura = entity.Cultura, IdEstatus = entity.IdEstatus });
                return _affectedRows;
            }
        }
    }
}
