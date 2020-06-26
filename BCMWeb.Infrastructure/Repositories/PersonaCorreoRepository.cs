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
    public class PersonaCorreoRepository : IPersonaCorreoRepository
    {
        private readonly IConfiguration _configuration;

        public PersonaCorreoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PersonaCorreo entity)
        {
            var sql = "INSERT INTO tblPersonaCorreo (IdEmpresa, IdPersona, , Correo, IdTipoCorreo) VALUES(@IdEmpresa, @IdPersona, , @Correo, @IdTipoCorreo);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idpersona, long idpersonacorreo)
        {
            var sql = "DELETE FROM tblPersonaCorreo WHERE IdEmpresa = @idempresa AND IdPersona = @idpersona AND IdPersonaCorreo = @idpersonacorreo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPersona = idpersona, IdPersonaCorreo = idpersonacorreo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PersonaCorreo> Get(long idempresa, long idpersona, long idpersonacorreo)
        {
            var sql = "SELECT IdEmpresa, IdPersona, IdPersonaCorreo, Correo, IdTipoCorreo FROM tblPersonaCorreo  WHERE IdEmpresa = @idempresa AND IdPersona = @idpersona AND IdPersonaCorreo = @idpersonacorreo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PersonaCorreo>(sql, new { IdEmpresa = idempresa, IdPersona = idpersona, IdPersonaCorreo = idpersonacorreo });
                PersonaCorreo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PersonaCorreo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PersonaCorreo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPersona, IdPersonaCorreo, Correo, IdTipoCorreo FROM tblPersonaCorreo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PersonaCorreo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PersonaCorreo entity)
        {
            var sql = "UPDATE tblPersonaCorreo SET IdEmpresa = @idempresa, IdPersona = @idpersona, , Correo = @correo, IdTipoCorreo = @idtipocorreo WHERE IdEmpresa = @idempresa AND IdPersona = @idpersona AND IdPersonaCorreo = @idpersonacorreo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPersona = entity.IdPersona, IdPersonaCorreo = entity.IdPersonaCorreo });
                return _affectedRows;
            }
        }
    }
}
