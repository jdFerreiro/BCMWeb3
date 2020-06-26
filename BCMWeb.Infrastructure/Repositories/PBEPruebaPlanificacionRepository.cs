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
    public class PBEPruebaPlanificacionRepository : IPBEPruebaPlanificacionRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaPlanificacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaPlanificacion entity)
        {
            var sql = "INSERT INTO tblPBEPruebaPlanificacion (IdEmpresa, , Negocios, Prueba, Propósito, FechaInicio, Lugar, IdEstatus) VALUES(@IdEmpresa, , @Negocios, @Prueba, @Propósito, @FechaInicio, @Lugar, @IdEstatus);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion)
        {
            var sql = "DELETE FROM tblPBEPruebaPlanificacion WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PBEPruebaPlanificacion> Get(long idempresa, long idplanificacion)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, Negocios, Prueba, Propósito, FechaInicio, Lugar, IdEstatus FROM tblPBEPruebaPlanificacion  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacion>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion });
                PBEPruebaPlanificacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaPlanificacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaPlanificacion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, Negocios, Prueba, Propósito, FechaInicio, Lugar, IdEstatus FROM tblPBEPruebaPlanificacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaPlanificacion entity)
        {
            var sql = "UPDATE tblPBEPruebaPlanificacion SET IdEmpresa = @idempresa, , Negocios = @negocios, Prueba = @prueba, Propósito = @propósito, FechaInicio = @fechainicio, Lugar = @lugar, IdEstatus = @idestatus WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion });
                return _affectedRows;
            }
        }
    }
}
