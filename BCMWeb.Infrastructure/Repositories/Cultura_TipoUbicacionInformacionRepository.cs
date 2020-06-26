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
    public class Cultura_TipoUbicacionInformacionRepository : ICultura_TipoUbicacionInformacionRepository
    {
        private readonly IConfiguration _configuration;

        public Cultura_TipoUbicacionInformacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cultura_TipoUbicacionInformacion entity)
        {
            var sql = "INSERT INTO tblCultura_TipoUbicacionInformacion (Culture, IdTipoUbicacionInformacion, Descripcion) VALUES(@Culture, @IdTipoUbicacionInformacion, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(string culture, int idtipoubicacioninformacion)
        {
            var sql = "DELETE FROM tblCultura_TipoUbicacionInformacion WHERE Culture = @culture AND IdTipoUbicacionInformacion = @idtipoubicacioninformacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = culture, IdTipoUbicacionInformacion = idtipoubicacioninformacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cultura_TipoUbicacionInformacion> Get(string culture, int idtipoubicacioninformacion)
        {
            var sql = "SELECT Culture, IdTipoUbicacionInformacion, Descripcion FROM tblCultura_TipoUbicacionInformacion  WHERE Culture = @culture AND IdTipoUbicacionInformacion = @idtipoubicacioninformacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoUbicacionInformacion>(sql, new { Culture = culture, IdTipoUbicacionInformacion = idtipoubicacioninformacion });
                Cultura_TipoUbicacionInformacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cultura_TipoUbicacionInformacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cultura_TipoUbicacionInformacion>> GetAll()
        {
            var sql = "SELECT Culture, IdTipoUbicacionInformacion, Descripcion FROM tblCultura_TipoUbicacionInformacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cultura_TipoUbicacionInformacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cultura_TipoUbicacionInformacion entity)
        {
            var sql = "UPDATE tblCultura_TipoUbicacionInformacion SET Culture = @culture, IdTipoUbicacionInformacion = @idtipoubicacioninformacion, Descripcion = @descripcion WHERE Culture = @culture AND IdTipoUbicacionInformacion = @idtipoubicacioninformacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Culture = entity.Culture, IdTipoUbicacionInformacion = entity.IdTipoUbicacionInformacion });
                return _affectedRows;
            }
        }

        Task<long> ICultura_TipoUbicacionInformacionRepository.Delete(string culture, int idtipoubicacioninformacion)
        {
            throw new System.NotImplementedException();
        }

        Task<Cultura_TipoUbicacionInformacion> ICultura_TipoUbicacionInformacionRepository.Get(string culture, int idtipoubicacioninformacion)
        {
            throw new System.NotImplementedException();
        }
    }
}
