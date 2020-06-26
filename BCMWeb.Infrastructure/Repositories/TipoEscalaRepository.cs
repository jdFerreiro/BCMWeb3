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
    public class TipoEscalaRepository : ITipoEscalaRepository
    {
        private readonly IConfiguration _configuration;

        public TipoEscalaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoEscala entity)
        {
            var sql = "INSERT INTO tblTipoEscala (IdEmpresa, IdTipoEscala, Descripcion) VALUES(@IdEmpresa, @IdTipoEscala, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idtipoescala)
        {
            var sql = "DELETE FROM tblTipoEscala WHERE IdEmpresa = @idempresa AND IdTipoEscala = @idtipoescala;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdTipoEscala = idtipoescala });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TipoEscala> Get(long idempresa, long idtipoescala)
        {
            var sql = "SELECT IdEmpresa, IdTipoEscala, Descripcion FROM tblTipoEscala  WHERE IdEmpresa = @idempresa AND IdTipoEscala = @idtipoescala;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoEscala>(sql, new { IdEmpresa = idempresa, IdTipoEscala = idtipoescala });
                TipoEscala _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<TipoEscala> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TipoEscala>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdTipoEscala, Descripcion FROM tblTipoEscala ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoEscala>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoEscala entity)
        {
            var sql = "UPDATE tblTipoEscala SET IdEmpresa = @idempresa, IdTipoEscala = @idtipoescala, Descripcion = @descripcion WHERE IdEmpresa = @idempresa AND IdTipoEscala = @idtipoescala;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdTipoEscala = entity.IdTipoEscala });
                return _affectedRows;
            }
        }
    }
}
