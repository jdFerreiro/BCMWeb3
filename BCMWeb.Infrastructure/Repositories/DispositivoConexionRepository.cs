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
    public class DispositivoConexionRepository : IDispositivoConexionRepository
    {
        private readonly IConfiguration _configuration;

        public DispositivoConexionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DispositivoConexion entity)
        {
            var sql = "INSERT INTO tblDispositivoConexion (IdEmpresa, IdDispositivo, IdUsuario, fechaConexion, DireccionIP) VALUES(@IdEmpresa, @IdDispositivo, @IdUsuario, @fechaConexion, @DireccionIP);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddispositivo, long idusuario, DateTime fechaconexion)
        {
            var sql = "DELETE FROM tblDispositivoConexion WHERE IdEmpresa = @idempresa AND IdDispositivo = @iddispositivo AND IdUsuario = @idusuario AND fechaConexion = @fechaconexion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDispositivo = iddispositivo, IdUsuario = idusuario, fechaConexion = fechaconexion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<DispositivoConexion> Get(long idempresa, long iddispositivo, long idusuario, DateTime fechaconexion)
        {
            var sql = "SELECT IdEmpresa, IdDispositivo, IdUsuario, fechaConexion, DireccionIP FROM tblDispositivoConexion  WHERE IdEmpresa = @idempresa AND IdDispositivo = @iddispositivo AND IdUsuario = @idusuario AND fechaConexion = @fechaconexion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DispositivoConexion>(sql, new { IdEmpresa = idempresa, IdDispositivo = iddispositivo, IdUsuario = idusuario, fechaConexion = fechaconexion });
                DispositivoConexion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DispositivoConexion> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DispositivoConexion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDispositivo, IdUsuario, fechaConexion, DireccionIP FROM tblDispositivoConexion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DispositivoConexion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DispositivoConexion entity)
        {
            var sql = "UPDATE tblDispositivoConexion SET IdEmpresa = @idempresa, IdDispositivo = @iddispositivo, IdUsuario = @idusuario, fechaConexion = @fechaconexion, DireccionIP = @direccionip WHERE IdEmpresa = @idempresa AND IdDispositivo = @iddispositivo AND IdUsuario = @idusuario AND fechaConexion = @fechaconexion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDispositivo = entity.IdDispositivo, IdUsuario = entity.IdUsuario, fechaConexion = entity.fechaConexion });
                return _affectedRows;
            }
        }
    }
}
