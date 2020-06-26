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
    public class DispositivoEnvioRepository : IDispositivoEnvioRepository
    {
        private readonly IConfiguration _configuration;

        public DispositivoEnvioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DispositivoEnvio entity)
        {
            var sql = "INSERT INTO tblDispositivoEnvio (IdDispositivo, IdSubModulo, IdEmpresa, IdUsuarioEnvia, FechaEnvio, FechaDescarga, Descargado) VALUES(@IdDispositivo, @IdSubModulo, @IdEmpresa, @IdUsuarioEnvia, @FechaEnvio, @FechaDescarga, @Descargado);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long iddispositivo, long idsubmodulo)
        {
            var sql = "DELETE FROM tblDispositivoEnvio WHERE IdDispositivo = @iddispositivo AND IdSubModulo = @idsubmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = iddispositivo, IdSubModulo = idsubmodulo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DispositivoEnvio> Get(long iddispositivo, long idsubmodulo)
        {
            var sql = "SELECT IdDispositivo, IdSubModulo, IdEmpresa, IdUsuarioEnvia, FechaEnvio, FechaDescarga, Descargado FROM tblDispositivoEnvio  WHERE IdDispositivo = @iddispositivo AND IdSubModulo = @idsubmodulo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DispositivoEnvio>(sql, new { IdDispositivo = iddispositivo, IdSubModulo = idsubmodulo });
                DispositivoEnvio _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DispositivoEnvio> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DispositivoEnvio>> GetAll()
        {
            var sql = "SELECT IdDispositivo, IdSubModulo, IdEmpresa, IdUsuarioEnvia, FechaEnvio, FechaDescarga, Descargado FROM tblDispositivoEnvio ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DispositivoEnvio>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DispositivoEnvio entity)
        {
            var sql = "UPDATE tblDispositivoEnvio SET IdDispositivo = @iddispositivo, IdSubModulo = @idsubmodulo, IdEmpresa = @idempresa, IdUsuarioEnvia = @idusuarioenvia, FechaEnvio = @fechaenvio, FechaDescarga = @fechadescarga, Descargado = @descargado WHERE IdDispositivo = @iddispositivo AND IdSubModulo = @idsubmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = entity.IdDispositivo, IdSubModulo = entity.IdSubModulo });
                return _affectedRows;
            }
        }
    }
}
