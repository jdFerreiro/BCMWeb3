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
    public class DocumentoPersonaClaveRepository : IDocumentoPersonaClaveRepository
    {
        private readonly IConfiguration _configuration;

        public DocumentoPersonaClaveRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(DocumentoPersonaClave entity)
        {
            var sql = "INSERT INTO tblDocumentoPersonaClave (IdEmpresa, IdDocumento, IdTipoDocumento, IdPersona, Nombre, Cedula, TelefonoOficina, TelefonoCelular, TelefonoHabitacion, Correo, DireccionHabitacion, Principal) VALUES(@IdEmpresa, @IdDocumento, @IdTipoDocumento, @IdPersona, @Nombre, @Cedula, @TelefonoOficina, @TelefonoCelular, @TelefonoHabitacion, @Correo, @DireccionHabitacion, @Principal);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idpersona)
        {
            var sql = "DELETE FROM tblDocumentoPersonaClave WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdPersona = @idpersona;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdPersona = idpersona });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DocumentoPersonaClave> Get(long idempresa, long iddocumento, long idtipodocumento, long idpersona)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdPersona, Nombre, Cedula, TelefonoOficina, TelefonoCelular, TelefonoHabitacion, Correo, DireccionHabitacion, Principal FROM tblDocumentoPersonaClave  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdPersona = @idpersona;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoPersonaClave>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdPersona = idpersona });
                DocumentoPersonaClave _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<DocumentoPersonaClave> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DocumentoPersonaClave>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdPersona, Nombre, Cedula, TelefonoOficina, TelefonoCelular, TelefonoHabitacion, Correo, DireccionHabitacion, Principal FROM tblDocumentoPersonaClave ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<DocumentoPersonaClave>(sql);
                return _result;
            }

        }
        public async Task<long> Update(DocumentoPersonaClave entity)
        {
            var sql = "UPDATE tblDocumentoPersonaClave SET IdEmpresa = @idempresa, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento, IdPersona = @idpersona, Nombre = @nombre, Cedula = @cedula, TelefonoOficina = @telefonooficina, TelefonoCelular = @telefonocelular, TelefonoHabitacion = @telefonohabitacion, Correo = @correo, DireccionHabitacion = @direccionhabitacion, Principal = @principal WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdPersona = @idpersona;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdTipoDocumento = entity.IdTipoDocumento, IdPersona = entity.IdPersona });
                return _affectedRows;
            }
        }
    }
}
