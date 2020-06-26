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
    public class TipoFrecuenciaRepository: ITipoFrecuenciaRepository
    {
        private readonly IConfiguration _configuration;

        public TipoFrecuenciaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoFrecuencia entity)
        {
            var sql = "INSERT INTO tblTipoFrecuencia (IdTipoFrecuencia) VALUES(@IdTipoFrecuencia);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idtipofrecuencia)
        {
            var sql = "DELETE FROM tblTipoFrecuencia WHERE IdTipoFrecuencia = @idtipofrecuencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoFrecuencia = idtipofrecuencia });
                return _affectedRows;
            }
        }
        public async Task<TipoFrecuencia> Get(long idtipofrecuencia)
        {
            var sql = "SELECT IdTipoFrecuencia FROM tblTipoFrecuencia  WHERE IdTipoFrecuencia = @idtipofrecuencia;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoFrecuencia>(sql, new { IdTipoFrecuencia = idtipofrecuencia });
                TipoFrecuencia _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<TipoFrecuencia>> GetAll()
        {
            var sql = "SELECT IdTipoFrecuencia FROM tblTipoFrecuencia ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoFrecuencia>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoFrecuencia entity)
        {
            var sql = "UPDATE tblTipoFrecuencia SET IdTipoFrecuencia = @idtipofrecuencia WHERE IdTipoFrecuencia = @idtipofrecuencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoFrecuencia = entity.IdTipoFrecuencia });
                return _affectedRows;
            }
        }
    }
}
