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
    public class PersonaDireccionRepository : IPersonaDireccionRepository
    {
        private readonly IConfiguration _configuration;

        public PersonaDireccionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PersonaDireccion entity)
        {
            var sql = "INSERT INTO tblPersonaDireccion (IdEmpresa, IdPersona, , IdTipoDireccion, Ubicacion, IdPais, IdEstado, IdCiudad) VALUES(@IdEmpresa, @IdPersona, , @IdTipoDireccion, @Ubicacion, @IdPais, @IdEstado, @IdCiudad);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idpersona, long idpersonadireccion)
        {
            var sql = "DELETE FROM tblPersonaDireccion WHERE IdEmpresa = @idempresa AND IdPersona = @idpersona AND IdPersonaDireccion = @idpersonadireccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPersona = idpersona, IdPersonaDireccion = idpersonadireccion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PersonaDireccion> Get(long idempresa, long idpersona, long idpersonadireccion)
        {
            var sql = "SELECT IdEmpresa, IdPersona, IdPersonaDireccion, IdTipoDireccion, Ubicacion, IdPais, IdEstado, IdCiudad FROM tblPersonaDireccion  WHERE IdEmpresa = @idempresa AND IdPersona = @idpersona AND IdPersonaDireccion = @idpersonadireccion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PersonaDireccion>(sql, new { IdEmpresa = idempresa, IdPersona = idpersona, IdPersonaDireccion = idpersonadireccion });
                PersonaDireccion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PersonaDireccion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PersonaDireccion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPersona, IdPersonaDireccion, IdTipoDireccion, Ubicacion, IdPais, IdEstado, IdCiudad FROM tblPersonaDireccion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PersonaDireccion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PersonaDireccion entity)
        {
            var sql = "UPDATE tblPersonaDireccion SET IdEmpresa = @idempresa, IdPersona = @idpersona, , IdTipoDireccion = @idtipodireccion, Ubicacion = @ubicacion, IdPais = @idpais, IdEstado = @idestado, IdCiudad = @idciudad WHERE IdEmpresa = @idempresa AND IdPersona = @idpersona AND IdPersonaDireccion = @idpersonadireccion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPersona = entity.IdPersona, IdPersonaDireccion = entity.IdPersonaDireccion });
                return _affectedRows;
            }
        }
    }
}
