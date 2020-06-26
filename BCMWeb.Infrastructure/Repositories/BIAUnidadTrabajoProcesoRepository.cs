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
    public class BIAUnidadTrabajoProcesoRepository : IBIAUnidadTrabajoProcesoRepository
    {
        private readonly IConfiguration _configuration;

        public BIAUnidadTrabajoProcesoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAUnidadTrabajoProceso entity)
        {
            var sql = "INSERT INTO tblBIAUnidadTrabajoProceso (IdEmpresa, IdUnidadTrabajo, , Nombre, IdDocumentoBIA, IdProceso) VALUES(@IdEmpresa, @IdUnidadTrabajo, , @Nombre, @IdDocumentoBIA, @IdProceso);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso)
        {
            var sql = "DELETE FROM tblBIAUnidadTrabajoProceso WHERE IdEmpresa = @idempresa AND IdUnidadTrabajo = @idunidadtrabajo AND IdUnidadTrabajoProceso = @idunidadtrabajoproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdUnidadTrabajo = idunidadtrabajo, IdUnidadTrabajoProceso = idunidadtrabajoproceso });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAUnidadTrabajoProceso> Get(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso)
        {
            var sql = "SELECT IdEmpresa, IdUnidadTrabajo, IdUnidadTrabajoProceso, Nombre, IdDocumentoBIA, IdProceso FROM tblBIAUnidadTrabajoProceso  WHERE IdEmpresa = @idempresa AND IdUnidadTrabajo = @idunidadtrabajo AND IdUnidadTrabajoProceso = @idunidadtrabajoproceso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAUnidadTrabajoProceso>(sql, new { IdEmpresa = idempresa, IdUnidadTrabajo = idunidadtrabajo, IdUnidadTrabajoProceso = idunidadtrabajoproceso });
                BIAUnidadTrabajoProceso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAUnidadTrabajoProceso> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAUnidadTrabajoProceso>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdUnidadTrabajo, IdUnidadTrabajoProceso, Nombre, IdDocumentoBIA, IdProceso FROM tblBIAUnidadTrabajoProceso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAUnidadTrabajoProceso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAUnidadTrabajoProceso entity)
        {
            var sql = "UPDATE tblBIAUnidadTrabajoProceso SET IdEmpresa = @idempresa, IdUnidadTrabajo = @idunidadtrabajo, , Nombre = @nombre, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso WHERE IdEmpresa = @idempresa AND IdUnidadTrabajo = @idunidadtrabajo AND IdUnidadTrabajoProceso = @idunidadtrabajoproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdUnidadTrabajo = entity.IdUnidadTrabajo, IdUnidadTrabajoProceso = entity.IdUnidadTrabajoProceso });
                return _affectedRows;
            }
        }
    }
}
