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
    public class PBEPruebaEjecucionResultadoRepository : IPBEPruebaEjecucionResultadoRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaEjecucionResultadoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaEjecucionResultado entity)
        {
            var sql = "INSERT INTO tblPBEPruebaEjecucionResultado (IdEmpresa, IdPlanificacion, IdContenido, Contenido) VALUES(@IdEmpresa, @IdPlanificacion, @IdContenido, @Contenido);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion, long idcontenido)
        {
            var sql = "DELETE FROM tblPBEPruebaEjecucionResultado WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdContenido = @idcontenido;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdContenido = idcontenido });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PBEPruebaEjecucionResultado> Get(long idempresa, long idplanificacion, long idcontenido)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdContenido, Contenido FROM tblPBEPruebaEjecucionResultado  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdContenido = @idcontenido;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionResultado>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdContenido = idcontenido });
                PBEPruebaEjecucionResultado _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaEjecucionResultado> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaEjecucionResultado>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdContenido, Contenido FROM tblPBEPruebaEjecucionResultado ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionResultado>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaEjecucionResultado entity)
        {
            var sql = "UPDATE tblPBEPruebaEjecucionResultado SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, IdContenido = @idcontenido, Contenido = @contenido WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdContenido = @idcontenido;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion, IdContenido = entity.IdContenido });
                return _affectedRows;
            }
        }
    }
}
