using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class DispositivoEnvio1Repository : IDispositivoEnvio1Repository
    {
        private readonly IConfiguration _configuration;

        public DispositivoEnvio1Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DispositivoEnvio1 entity)
        {
            var sql = "INSERT INTO tblDispositivoEnvio1 (IdDispositivo, IdUsuario, IdEmpresa, IdSubModulo, IdUsuarioEnvia, FechaEnvio, FechaDescarga, Descargado) VALUES(@IdDispositivo, @IdUsuario, @IdEmpresa, @IdSubModulo, @IdUsuarioEnvia, @FechaEnvio, @FechaDescarga, @Descargado);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long iddispositivo, long idusuario, long idempresa, long idsubmodulo, long idusuarioenvia, DateTime fechaenvio)
        {
            var sql = "DELETE FROM tblDispositivoEnvio1 WHERE IdDispositivo = @iddispositivo AND IdUsuario = @idusuario AND IdEmpresa = @idempresa AND IdSubModulo = @idsubmodulo AND IdUsuarioEnvia = @idusuarioenvia AND FechaEnvio = @fechaenvio;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = iddispositivo, IdUsuario = idusuario, IdEmpresa = idempresa, IdSubModulo = idsubmodulo, IdUsuarioEnvia = idusuarioenvia, FechaEnvio = fechaenvio });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DispositivoEnvio1> Get(long iddispositivo, long idusuario, long idempresa, long idsubmodulo, long idusuarioenvia, DateTime fechaenvio)
        {
            var sql = "SELECT IdDispositivo, IdUsuario, IdEmpresa, IdSubModulo, IdUsuarioEnvia, FechaEnvio, FechaDescarga, Descargado FROM tblDispositivoEnvio1  WHERE IdDispositivo = @iddispositivo AND IdUsuario = @idusuario AND IdEmpresa = @idempresa AND IdSubModulo = @idsubmodulo AND IdUsuarioEnvia = @idusuarioenvia AND FechaEnvio = @fechaenvio;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DispositivoEnvio1>(sql, new { IdDispositivo = iddispositivo, IdUsuario = idusuario, IdEmpresa = idempresa, IdSubModulo = idsubmodulo, IdUsuarioEnvia = idusuarioenvia, FechaEnvio = fechaenvio });
                DispositivoEnvio1 _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DispositivoEnvio1> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DispositivoEnvio1>> GetAll()
        {
            var sql = "SELECT IdDispositivo, IdUsuario, IdEmpresa, IdSubModulo, IdUsuarioEnvia, FechaEnvio, FechaDescarga, Descargado FROM tblDispositivoEnvio1 ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DispositivoEnvio1>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DispositivoEnvio1 entity)
        {
            var sql = "UPDATE tblDispositivoEnvio1 SET IdDispositivo = @iddispositivo, IdUsuario = @idusuario, IdEmpresa = @idempresa, IdSubModulo = @idsubmodulo, IdUsuarioEnvia = @idusuarioenvia, FechaEnvio = @fechaenvio, FechaDescarga = @fechadescarga, Descargado = @descargado WHERE IdDispositivo = @iddispositivo AND IdUsuario = @idusuario AND IdEmpresa = @idempresa AND IdSubModulo = @idsubmodulo AND IdUsuarioEnvia = @idusuarioenvia AND FechaEnvio = @fechaenvio;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = entity.IdDispositivo, IdUsuario = entity.IdUsuario, IdEmpresa = entity.IdEmpresa, IdSubModulo = entity.IdSubModulo, IdUsuarioEnvia = entity.IdUsuarioEnvia, FechaEnvio = entity.FechaEnvio });
                return _affectedRows;
            }
        }
    }
}
