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
    public class PBEPruebaPlanificacionParticipanteRepository : IPBEPruebaPlanificacionParticipanteRepository
    {
        private readonly IConfiguration _configuration;

        public PBEPruebaPlanificacionParticipanteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PBEPruebaPlanificacionParticipante entity)
        {
            var sql = "INSERT INTO tblPBEPruebaPlanificacionParticipante (IdEmpresa, IdPlanificacion, , Empresa, Nombre, Responsable, Correo, Telefono) VALUES(@IdEmpresa, @IdPlanificacion, , @Empresa, @Nombre, @Responsable, @Correo, @Telefono);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idplanificacion, long idparticipante)
        {
            var sql = "DELETE FROM tblPBEPruebaPlanificacionParticipante WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdParticipante = @idparticipante;";
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

        public async Task<PBEPruebaPlanificacionParticipante> Get(long idempresa, long idplanificacion, long idparticipante)
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdParticipante, Empresa, Nombre, Responsable, Correo, Telefono FROM tblPBEPruebaPlanificacionParticipante  WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdParticipante = @idparticipante;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacionParticipante>(sql, new { IdEmpresa = idempresa, IdPlanificacion = idplanificacion, IdParticipante = idparticipante });
                PBEPruebaPlanificacionParticipante _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PBEPruebaPlanificacionParticipante> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PBEPruebaPlanificacionParticipante>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPlanificacion, IdParticipante, Empresa, Nombre, Responsable, Correo, Telefono FROM tblPBEPruebaPlanificacionParticipante ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PBEPruebaPlanificacionParticipante>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PBEPruebaPlanificacionParticipante entity)
        {
            var sql = "UPDATE tblPBEPruebaPlanificacionParticipante SET IdEmpresa = @idempresa, IdPlanificacion = @idplanificacion, , Empresa = @empresa, Nombre = @nombre, Responsable = @responsable, Correo = @correo, Telefono = @telefono WHERE IdEmpresa = @idempresa AND IdPlanificacion = @idplanificacion AND IdParticipante = @idparticipante;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPlanificacion = entity.IdPlanificacion, IdParticipante = entity.IdParticipante });
                return _affectedRows;
            }
        }
    }
}
