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
    public class LocalidadRepository : ILocalidadRepository
    {
        private readonly IConfiguration _configuration;

        public LocalidadRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Localidad entity)
        {
            var sql = "INSERT INTO tblLocalidad (IdEmpresa, , Codigo, Nombre, IdPais, IdEstado, IdCiudad) VALUES(@IdEmpresa, , @Codigo, @Nombre, @IdPais, @IdEstado, @IdCiudad);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idlocalidad)
        {
            var sql = "DELETE FROM tblLocalidad WHERE IdEmpresa = @idempresa AND IdLocalidad = @idlocalidad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdLocalidad = idlocalidad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Localidad> Get(long idempresa, long idlocalidad)
        {
            var sql = "SELECT IdEmpresa, IdLocalidad, Codigo, Nombre, IdPais, IdEstado, IdCiudad FROM tblLocalidad  WHERE IdEmpresa = @idempresa AND IdLocalidad = @idlocalidad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Localidad>(sql, new { IdEmpresa = idempresa, IdLocalidad = idlocalidad });
                Localidad _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Localidad> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Localidad>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdLocalidad, Codigo, Nombre, IdPais, IdEstado, IdCiudad FROM tblLocalidad ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Localidad>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Localidad entity)
        {
            var sql = "UPDATE tblLocalidad SET IdEmpresa = @idempresa, , Codigo = @codigo, Nombre = @nombre, IdPais = @idpais, IdEstado = @idestado, IdCiudad = @idciudad WHERE IdEmpresa = @idempresa AND IdLocalidad = @idlocalidad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdLocalidad = entity.IdLocalidad });
                return _affectedRows;
            }
        }
    }
}
