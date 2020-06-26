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
    public class DispositivoConexion1Repository : IDispositivoConexion1Repository
    {
        private readonly IConfiguration _configuration;

        public DispositivoConexion1Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DispositivoConexion1 entity)
        {
            var sql = "INSERT INTO tblDispositivoConexion1 (IdDispositivo, IdUsuario, FechaConexion, IdEmpresa, IdSubModulo, DirecciónIP) VALUES(@IdDispositivo, @IdUsuario, @FechaConexion, @IdEmpresa, @IdSubModulo, @DirecciónIP);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long iddispositivo, long idusuario, DateTime fechaconexion)
        {
            var sql = "DELETE FROM tblDispositivoConexion1 WHERE IdDispositivo = @iddispositivo AND IdUsuario = @idusuario AND FechaConexion = @fechaconexion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = iddispositivo, IdUsuario = idusuario, FechaConexion = fechaconexion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<DispositivoConexion1> Get(long iddispositivo, long idusuario, DateTime fechaconexion)
        {
            var sql = "SELECT IdDispositivo, IdUsuario, FechaConexion, IdEmpresa, IdSubModulo, DirecciónIP FROM tblDispositivoConexion1  WHERE IdDispositivo = @iddispositivo AND IdUsuario = @idusuario AND FechaConexion = @fechaconexion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DispositivoConexion1>(sql, new { IdDispositivo = iddispositivo, IdUsuario = idusuario, FechaConexion = fechaconexion });
                DispositivoConexion1 _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DispositivoConexion1> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DispositivoConexion1>> GetAll()
        {
            var sql = "SELECT IdDispositivo, IdUsuario, FechaConexion, IdEmpresa, IdSubModulo, DirecciónIP FROM tblDispositivoConexion1 ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DispositivoConexion1>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DispositivoConexion1 entity)
        {
            var sql = "UPDATE tblDispositivoConexion1 SET IdDispositivo = @iddispositivo, IdUsuario = @idusuario, FechaConexion = @fechaconexion, IdEmpresa = @idempresa, IdSubModulo = @idsubmodulo, DirecciónIP = @direcciónip WHERE IdDispositivo = @iddispositivo AND IdUsuario = @idusuario AND FechaConexion = @fechaconexion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = entity.IdDispositivo, IdUsuario = entity.IdUsuario, FechaConexion = entity.FechaConexion });
                return _affectedRows;
            }
        }
    }
}
