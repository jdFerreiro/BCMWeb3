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
    public class PersonaTelefonoRepository : IPersonaTelefonoRepository
    {
        private readonly IConfiguration _configuration;

        public PersonaTelefonoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PersonaTelefono entity)
        {
            var sql = "INSERT INTO tblPersonaTelefono (IdEmpresa, IdPersona, , IdTipoTelefono, Telefono) VALUES(@IdEmpresa, @IdPersona, , @IdTipoTelefono, @Telefono);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idpersona, long idpersonatelefono)
        {
            var sql = "DELETE FROM tblPersonaTelefono WHERE IdEmpresa = @idempresa AND IdPersona = @idpersona AND IdPersonaTelefono = @idpersonatelefono;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPersona = idpersona, IdPersonaTelefono = idpersonatelefono });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PersonaTelefono> Get(long idempresa, long idpersona, long idpersonatelefono)
        {
            var sql = "SELECT IdEmpresa, IdPersona, IdPersonaTelefono, IdTipoTelefono, Telefono FROM tblPersonaTelefono  WHERE IdEmpresa = @idempresa AND IdPersona = @idpersona AND IdPersonaTelefono = @idpersonatelefono;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PersonaTelefono>(sql, new { IdEmpresa = idempresa, IdPersona = idpersona, IdPersonaTelefono = idpersonatelefono });
                PersonaTelefono _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PersonaTelefono> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PersonaTelefono>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPersona, IdPersonaTelefono, IdTipoTelefono, Telefono FROM tblPersonaTelefono ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PersonaTelefono>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PersonaTelefono entity)
        {
            var sql = "UPDATE tblPersonaTelefono SET IdEmpresa = @idempresa, IdPersona = @idpersona, , IdTipoTelefono = @idtipotelefono, Telefono = @telefono WHERE IdEmpresa = @idempresa AND IdPersona = @idpersona AND IdPersonaTelefono = @idpersonatelefono;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPersona = entity.IdPersona, IdPersonaTelefono = entity.IdPersonaTelefono });
                return _affectedRows;
            }
        }

        Task<long> IPersonaTelefonoRepository.Delete(long idempresa, long idpersona, long idpersonatelefono)
        {
            throw new System.NotImplementedException();
        }

        Task<PersonaTelefono> IPersonaTelefonoRepository.Get(long idempresa, long idpersona, long idpersonatelefono)
        {
            throw new System.NotImplementedException();
        }
    }
}
