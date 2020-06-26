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
    public class PMTResponsableUpdate_CorreoRepository : IPMTResponsableUpdate_CorreoRepository
    {
        private readonly IConfiguration _configuration;

        public PMTResponsableUpdate_CorreoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PMTResponsableUpdate_Correo entity)
        {
            var sql = "INSERT INTO tblPMTResponsableUpdate_Correo (IdEmpresa, IdModulo, IdMensaje, IdUsuario, FechaRegistro) VALUES(@IdEmpresa, @IdModulo, @IdMensaje, @IdUsuario, @FechaRegistro);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idmodulo, long idmensaje, long idusuario)
        {
            var sql = "DELETE FROM tblPMTResponsableUpdate_Correo WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdMensaje = @idmensaje AND IdUsuario = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo, IdMensaje = idmensaje, IdUsuario = idusuario });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PMTResponsableUpdate_Correo> Get(long idempresa, long idmodulo, long idmensaje, long idusuario)
        {
            var sql = "SELECT IdEmpresa, IdModulo, IdMensaje, IdUsuario, FechaRegistro FROM tblPMTResponsableUpdate_Correo  WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdMensaje = @idmensaje AND IdUsuario = @idusuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTResponsableUpdate_Correo>(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo, IdMensaje = idmensaje, IdUsuario = idusuario });
                PMTResponsableUpdate_Correo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PMTResponsableUpdate_Correo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PMTResponsableUpdate_Correo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdModulo, IdMensaje, IdUsuario, FechaRegistro FROM tblPMTResponsableUpdate_Correo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTResponsableUpdate_Correo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PMTResponsableUpdate_Correo entity)
        {
            var sql = "UPDATE tblPMTResponsableUpdate_Correo SET IdEmpresa = @idempresa, IdModulo = @idmodulo, IdMensaje = @idmensaje, IdUsuario = @idusuario, FechaRegistro = @fecharegistro WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND IdMensaje = @idmensaje AND IdUsuario = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdModulo = entity.IdModulo, IdMensaje = entity.IdMensaje, IdUsuario = entity.IdUsuario });
                return _affectedRows;
            }
        }
    }
}
