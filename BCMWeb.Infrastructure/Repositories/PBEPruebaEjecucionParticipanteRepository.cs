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
    public class PBEPruebaEjecucionParticipanteRepository : IPBEPruebaEjecucionParticipanteRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaEjecucionParticipanteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaEjecucionParticipante entity)
        {
            var sql = "INSERT INTO tblPBEPruebaEjecucionParticipante (IdEmpresa, IdPlanificacion, , Empresa, Nombre, Responsable, Correo, Telefono, IdPlanificacionParticipante) VALUES(@IdEmpresa, @IdPlanificacion, , @Empresa, @Nombre, @Responsable, @Correo, @Telefono, @IdPlanificacionParticipante);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion, long idparticipante)
        {
            var sql = "DELETE FROM tblPBEPruebaEjecucionParticipante WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdParticipante = @idparticipante;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdParticipante = idparticipante });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PBEPruebaEjecucionParticipante> Get(long idempresa, long idplanificacion, long idparticipante)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdParticipante, Empresa, Nombre, Responsable, Correo, Telefono, IdPlanificacionParticipante FROM tblPBEPruebaEjecucionParticipante  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdParticipante = @idparticipante;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionParticipante>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdParticipante = idparticipante });
                PBEPruebaEjecucionParticipante _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaEjecucionParticipante> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaEjecucionParticipante>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdParticipante, Empresa, Nombre, Responsable, Correo, Telefono, IdPlanificacionParticipante FROM tblPBEPruebaEjecucionParticipante ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaEjecucionParticipante>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaEjecucionParticipante entity)
        {
            var sql = "UPDATE tblPBEPruebaEjecucionParticipante SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, , Empresa = @empresa, Nombre = @nombre, Responsable = @responsable, Correo = @correo, Telefono = @telefono, IdPlanificacionParticipante = @idplanificacionparticipante WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdParticipante = @idparticipante;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion, IdParticipante = entity.IdParticipante });
                return _affectedRows;
            }
        }
    }
}
