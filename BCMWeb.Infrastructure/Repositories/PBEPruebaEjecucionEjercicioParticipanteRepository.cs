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
    public class PBEPruebaEjecucionEjercicioParticipanteRepository : IPBEPruebaEjecucionEjercicioParticipanteRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaEjecucionEjercicioParticipanteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaEjecucionEjercicioParticipante entity)
        {
            var sql = "INSERT INTO tblPBEPruebaEjecucionEjercicioParticipante (IdEmpresa, IdPlanificacion, IdEjercicio, IdParticipante, Responsable) VALUES(@IdEmpresa, @IdPlanificacion, @IdEjercicio, @IdParticipante, @Responsable);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idparticipante)
        {
            var sql = "DELETE FROM tblPBEPruebaEjecucionEjercicioParticipante WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdParticipante = @idparticipante;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdEjercicio = idejercicio, IdParticipante = idparticipante });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PBEPruebaEjecucionEjercicioParticipante> Get(long idempresa, long idplanificacion, long idejercicio, long idparticipante)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, IdParticipante, Responsable FROM tblPBEPruebaEjecucionEjercicioParticipante  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdParticipante = @idparticipante;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionEjercicioParticipante>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdEjercicio = idejercicio, IdParticipante = idparticipante });
                PBEPruebaEjecucionEjercicioParticipante _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaEjecucionEjercicioParticipante> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaEjecucionEjercicioParticipante>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, IdParticipante, Responsable FROM tblPBEPruebaEjecucionEjercicioParticipante ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionEjercicioParticipante>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaEjecucionEjercicioParticipante entity)
        {
            var sql = "UPDATE tblPBEPruebaEjecucionEjercicioParticipante SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, IdEjercicio = @idejercicio, IdParticipante = @idparticipante, Responsable = @responsable WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdParticipante = @idparticipante;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion, IdEjercicio = entity.IdEjercicio, IdParticipante = entity.IdParticipante });
                return _affectedRows;
            }
        }
    }
}
