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
    public class BCPReanudacionPersonaClaveRepository : IBCPReanudacionPersonaClaveRepository
    {
        private readonly IConfiguration _configuration;

        public BCPReanudacionPersonaClaveRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPReanudacionPersonaClave entity)
        {
            var sql = "INSERT INTO tblBCPReanudacionPersonaClave (IdEmpresa, IdDocumentoBCP, , Actividad, Nombre, Cedula, TelefonoOficina, TelefonoCelular, TelefonoHabitacion, Correo, DireccionHabitacion, IdPersonaClavePrincipal) VALUES(@IdEmpresa, @IdDocumentoBCP, , @Actividad, @Nombre, @Cedula, @TelefonoOficina, @TelefonoCelular, @TelefonoHabitacion, @Correo, @DireccionHabitacion, @IdPersonaClavePrincipal);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idpersona)
        {
            var sql = "DELETE FROM tblBCPReanudacionPersonaClave WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdPersona = @idpersona;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdPersona = idpersona });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPReanudacionPersonaClave> Get(long idempresa, long iddocumentobcp, long idpersona)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdPersona, Actividad, Nombre, Cedula, TelefonoOficina, TelefonoCelular, TelefonoHabitacion, Correo, DireccionHabitacion, IdPersonaClavePrincipal FROM tblBCPReanudacionPersonaClave  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdPersona = @idpersona;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPReanudacionPersonaClave>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdPersona = idpersona });
                BCPReanudacionPersonaClave _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPReanudacionPersonaClave> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPReanudacionPersonaClave>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdPersona, Actividad, Nombre, Cedula, TelefonoOficina, TelefonoCelular, TelefonoHabitacion, Correo, DireccionHabitacion, IdPersonaClavePrincipal FROM tblBCPReanudacionPersonaClave ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPReanudacionPersonaClave>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPReanudacionPersonaClave entity)
        {
            var sql = "UPDATE tblBCPReanudacionPersonaClave SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, , Actividad = @actividad, Nombre = @nombre, Cedula = @cedula, TelefonoOficina = @telefonooficina, TelefonoCelular = @telefonocelular, TelefonoHabitacion = @telefonohabitacion, Correo = @correo, DireccionHabitacion = @direccionhabitacion, IdPersonaClavePrincipal = @idpersonaclaveprincipal WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdPersona = @idpersona;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdPersona = entity.IdPersona });
                return _affectedRows;
            }
        }
    }
}
