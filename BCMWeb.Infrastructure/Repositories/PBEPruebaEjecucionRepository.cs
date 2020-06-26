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
    public class PBEPruebaEjecucionRepository : IPBEPruebaEjecucionRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaEjecucionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaEjecucion entity)
        {
            var sql = "INSERT INTO tblPBEPruebaEjecucion (IdEmpresa, IdPlanificacion, FechaInicio, Lugar) VALUES(@IdEmpresa, @IdPlanificacion, @FechaInicio, @Lugar);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion)
        {
            var sql = "DELETE FROM tblPBEPruebaEjecucion WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion;";
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

        public async Task<PBEPruebaEjecucion> Get(long idempresa, long idplanificacion)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, FechaInicio, Lugar FROM tblPBEPruebaEjecucion  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucion>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion });
                PBEPruebaEjecucion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaEjecucion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaEjecucion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, FechaInicio, Lugar FROM tblPBEPruebaEjecucion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaEjecucion entity)
        {
            var sql = "UPDATE tblPBEPruebaEjecucion SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, FechaInicio = @fechainicio, Lugar = @lugar WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion });
                return _affectedRows;
            }
        }
    }
}
