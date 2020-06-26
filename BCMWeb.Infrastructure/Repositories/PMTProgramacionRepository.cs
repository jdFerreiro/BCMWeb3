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
    public class PMTProgramacionRepository: IPMTProgramacionRepository
    {
        private readonly IConfiguration _configuration;

        public PMTProgramacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PMTProgramacion entity)
        {
            var sql = "INSERT INTO tblPMTProgramacion (IdEmpresa, IdModulo, FechaInicio, FechaFinal, IdEstado, Negocios, IdTipoActualizacion, IdTipoFrecuencia) VALUES(@IdEmpresa, @IdModulo, @FechaInicio, @FechaFinal, @IdEstado, @Negocios, @IdTipoActualizacion, @IdTipoFrecuencia);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idpmtprogramacion)
        {
            var sql = "DELETE FROM tblPMTProgramacion WHERE IdPMTProgramacion = @idpmtprogramacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPMTProgramacion = idpmtprogramacion });
                return _affectedRows;
            }
        }
        public async Task<PMTProgramacion> Get(long idpmtprogramacion)
        {
            var sql = "SELECT IdPMTProgramacion, IdEmpresa, IdModulo, FechaInicio, FechaFinal, IdEstado, Negocios, IdTipoActualizacion, IdTipoFrecuencia FROM tblPMTProgramacion  WHERE IdPMTProgramacion = @idpmtprogramacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacion>(sql, new { IdPMTProgramacion = idpmtprogramacion });
                PMTProgramacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<PMTProgramacion>> GetAll()
        {
            var sql = "SELECT IdPMTProgramacion, IdEmpresa, IdModulo, FechaInicio, FechaFinal, IdEstado, Negocios, IdTipoActualizacion, IdTipoFrecuencia FROM tblPMTProgramacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PMTProgramacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PMTProgramacion entity)
        {
            var sql = "UPDATE tblPMTProgramacion SET IdEmpresa = @idempresa, IdModulo = @idmodulo, FechaInicio = @fechainicio, FechaFinal = @fechafinal, IdEstado = @idestado, Negocios = @negocios, IdTipoActualizacion = @idtipoactualizacion, IdTipoFrecuencia = @idtipofrecuencia WHERE IdPMTProgramacion = @idpmtprogramacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdPMTProgramacion = entity.IdPMTProgramacion });
                return _affectedRows;
            }
        }
    }
}
