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
    public class IncidentesRepository : IIncidentesRepository
    {
        private readonly IConfiguration _configuration;

        public IncidentesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Incidentes entity)
        {
            var sql = "INSERT INTO tblIncidentes (IdEmpresa, , IdTipoIncidente, IdNaturalezaIncidente, IdFuenteIncidente, FechaIncidente, Descripcion, LugarIncidente, Duracion, NombreReportero, NombreSolucionador, Observaciones) VALUES(@IdEmpresa, , @IdTipoIncidente, @IdNaturalezaIncidente, @IdFuenteIncidente, @FechaIncidente, @Descripcion, @LugarIncidente, @Duracion, @NombreReportero, @NombreSolucionador, @Observaciones);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idincidente)
        {
            var sql = "DELETE FROM tblIncidentes WHERE IdEmpresa = @idempresa AND IdIncidente = @idincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdIncidente = idincidente });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Incidentes> Get(long idempresa, long idincidente)
        {
            var sql = "SELECT IdEmpresa, IdIncidente, IdTipoIncidente, IdNaturalezaIncidente, IdFuenteIncidente, FechaIncidente, Descripcion, LugarIncidente, Duracion, NombreReportero, NombreSolucionador, Observaciones FROM tblIncidentes  WHERE IdEmpresa = @idempresa AND IdIncidente = @idincidente;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Incidentes>(sql, new { IdEmpresa = idempresa, IdIncidente = idincidente });
                Incidentes _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Incidentes> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Incidentes>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdIncidente, IdTipoIncidente, IdNaturalezaIncidente, IdFuenteIncidente, FechaIncidente, Descripcion, LugarIncidente, Duracion, NombreReportero, NombreSolucionador, Observaciones FROM tblIncidentes ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Incidentes>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Incidentes entity)
        {
            var sql = "UPDATE tblIncidentes SET IdEmpresa = @idempresa, , IdTipoIncidente = @idtipoincidente, IdNaturalezaIncidente = @idnaturalezaincidente, IdFuenteIncidente = @idfuenteincidente, FechaIncidente = @fechaincidente, Descripcion = @descripcion, LugarIncidente = @lugarincidente, Duracion = @duracion, NombreReportero = @nombrereportero, NombreSolucionador = @nombresolucionador, Observaciones = @observaciones WHERE IdEmpresa = @idempresa AND IdIncidente = @idincidente;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdIncidente = entity.IdIncidente });
                return _affectedRows;
            }
        }
    }
}
