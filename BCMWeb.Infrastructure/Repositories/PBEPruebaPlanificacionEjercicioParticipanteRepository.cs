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
    public class PBEPruebaPlanificacionEjercicioParticipanteRepository : IPBEPruebaPlanificacionEjercicioParticipanteRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaPlanificacionEjercicioParticipanteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaPlanificacionEjercicioParticipante entity)
        {
            var sql = "INSERT INTO tblPBEPruebaPlanificacionEjercicioParticipante (IdEmpresa, IdPlanificacion, IdEjercicio, IdParticipante, Responsable) VALUES(@IdEmpresa, @IdPlanificacion, @IdEjercicio, @IdParticipante, @Responsable);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idparticipante)
        {
            var sql = "DELETE FROM tblPBEPruebaPlanificacionEjercicioParticipante WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdParticipante = @idparticipante;";
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

        public async Task<PBEPruebaPlanificacionEjercicioParticipante> Get(long idempresa, long idplanificacion, long idejercicio, long idparticipante)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, IdParticipante, Responsable FROM tblPBEPruebaPlanificacionEjercicioParticipante  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdParticipante = @idparticipante;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacionEjercicioParticipante>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdEjercicio = idejercicio, IdParticipante = idparticipante });
                PBEPruebaPlanificacionEjercicioParticipante _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaPlanificacionEjercicioParticipante> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaPlanificacionEjercicioParticipante>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdEjercicio, IdParticipante, Responsable FROM tblPBEPruebaPlanificacionEjercicioParticipante ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacionEjercicioParticipante>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaPlanificacionEjercicioParticipante entity)
        {
            var sql = "UPDATE tblPBEPruebaPlanificacionEjercicioParticipante SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, IdEjercicio = @idejercicio, IdParticipante = @idparticipante, Responsable = @responsable WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdEjercicio = @idejercicio AND IdParticipante = @idparticipante;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion, IdEjercicio = entity.IdEjercicio, IdParticipante = entity.IdParticipante });
                return _affectedRows;
            }
        }
    }
}
