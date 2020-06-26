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
    public class VicepresidenciaRepository : IVicepresidenciaRepository
    {
        private readonly IConfiguration _configuration;

        public VicepresidenciaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Vicepresidencia entity)
        {
            var sql = "INSERT INTO tblVicepresidencia (IdEmpresa, , Nombre, CalleAvenida, EdificioCasa, PisoNivel, TorreAla, Urbanizacion, IdCiudad, IdEstado, IdPais) VALUES(@IdEmpresa, , @Nombre, @CalleAvenida, @EdificioCasa, @PisoNivel, @TorreAla, @Urbanizacion, @IdCiudad, @IdEstado, @IdPais);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idvicepresidencia)
        {
            var sql = "DELETE FROM tblVicepresidencia WHERE IdEmpresa = @idempresa AND IdVicepresidencia = @idvicepresidencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdVicepresidencia = idvicepresidencia });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Vicepresidencia> Get(long idempresa, long idvicepresidencia)
        {
            var sql = "SELECT IdEmpresa, IdVicepresidencia, Nombre, CalleAvenida, EdificioCasa, PisoNivel, TorreAla, Urbanizacion, IdCiudad, IdEstado, IdPais FROM tblVicepresidencia  WHERE IdEmpresa = @idempresa AND IdVicepresidencia = @idvicepresidencia;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Vicepresidencia>(sql, new { IdEmpresa = idempresa, IdVicepresidencia = idvicepresidencia });
                Vicepresidencia _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Vicepresidencia> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Vicepresidencia>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdVicepresidencia, Nombre, CalleAvenida, EdificioCasa, PisoNivel, TorreAla, Urbanizacion, IdCiudad, IdEstado, IdPais FROM tblVicepresidencia ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Vicepresidencia>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Vicepresidencia entity)
        {
            var sql = "UPDATE tblVicepresidencia SET IdEmpresa = @idempresa, , Nombre = @nombre, CalleAvenida = @calleavenida, EdificioCasa = @edificiocasa, PisoNivel = @pisonivel, TorreAla = @torreala, Urbanizacion = @urbanizacion, IdCiudad = @idciudad, IdEstado = @idestado, IdPais = @idpais WHERE IdEmpresa = @idempresa AND IdVicepresidencia = @idvicepresidencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdVicepresidencia = entity.IdVicepresidencia });
                return _affectedRows;
            }
        }
    }
}
