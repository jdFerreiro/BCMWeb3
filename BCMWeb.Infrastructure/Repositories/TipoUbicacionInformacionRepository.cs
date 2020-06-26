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
    public class TipoUbicacionInformacionRepository : ITipoUbicacionInformacionRepository
    {
        private readonly IConfiguration _configuration;

        public TipoUbicacionInformacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(TipoUbicacionInformacion entity)
        {
            var sql = "INSERT INTO tblTipoUbicacionInformacion (IdTipoUbicacionInformacion) VALUES(@IdTipoUbicacionInformacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(int idtipoubicacioninformacion)
        {
            var sql = "DELETE FROM tblTipoUbicacionInformacion WHERE IdTipoUbicacionInformacion = @idtipoubicacioninformacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoUbicacionInformacion = idtipoubicacioninformacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TipoUbicacionInformacion> Get(int idtipoubicacioninformacion)
        {
            var sql = "SELECT IdTipoUbicacionInformacion FROM tblTipoUbicacionInformacion  WHERE IdTipoUbicacionInformacion = @idtipoubicacioninformacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoUbicacionInformacion>(sql, new { IdTipoUbicacionInformacion = idtipoubicacioninformacion });
                TipoUbicacionInformacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<TipoUbicacionInformacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TipoUbicacionInformacion>> GetAll()
        {
            var sql = "SELECT IdTipoUbicacionInformacion FROM tblTipoUbicacionInformacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TipoUbicacionInformacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TipoUbicacionInformacion entity)
        {
            var sql = "UPDATE tblTipoUbicacionInformacion SET IdTipoUbicacionInformacion = @idtipoubicacioninformacion WHERE IdTipoUbicacionInformacion = @idtipoubicacioninformacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdTipoUbicacionInformacion = entity.IdTipoUbicacionInformacion });
                return _affectedRows;
            }
        }
    }
}
