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
    public class BIAUnidadTrabajoPersonasRepository : IBIAUnidadTrabajoPersonasRepository
    {
        private readonly IConfiguration _configuration;

        public BIAUnidadTrabajoPersonasRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAUnidadTrabajoPersonas entity)
        {
            var sql = "INSERT INTO tblBIAUnidadTrabajoPersonas (IdEmpresa, IdUnidadTrabajo, IdUnidadTrabajoProceso, , IdClienteProceso, Nombre, IdDocumentoBIA, IdProceso) VALUES(@IdEmpresa, @IdUnidadTrabajo, @IdUnidadTrabajoProceso, , @IdClienteProceso, @Nombre, @IdDocumentoBIA, @IdProceso);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso, long idunidadpersona, long idclienteproceso)
        {
            var sql = "DELETE FROM tblBIAUnidadTrabajoPersonas WHERE IdEmpresa = @idempresa AND IdUnidadTrabajo = @idunidadtrabajo AND IdUnidadTrabajoProceso = @idunidadtrabajoproceso AND IdUnidadPersona = @idunidadpersona AND IdClienteProceso = @idclienteproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdUnidadTrabajo = idunidadtrabajo, IdUnidadTrabajoProceso = idunidadtrabajoproceso, IdUnidadPersona = idunidadpersona, IdClienteProceso = idclienteproceso });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAUnidadTrabajoPersonas> Get(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso, long idunidadpersona, long idclienteproceso)
        {
            var sql = "SELECT IdEmpresa, IdUnidadTrabajo, IdUnidadTrabajoProceso, IdUnidadPersona, IdClienteProceso, Nombre, IdDocumentoBIA, IdProceso FROM tblBIAUnidadTrabajoPersonas  WHERE IdEmpresa = @idempresa AND IdUnidadTrabajo = @idunidadtrabajo AND IdUnidadTrabajoProceso = @idunidadtrabajoproceso AND IdUnidadPersona = @idunidadpersona AND IdClienteProceso = @idclienteproceso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAUnidadTrabajoPersonas>(sql, new { IdEmpresa = idempresa, IdUnidadTrabajo = idunidadtrabajo, IdUnidadTrabajoProceso = idunidadtrabajoproceso, IdUnidadPersona = idunidadpersona, IdClienteProceso = idclienteproceso });
                BIAUnidadTrabajoPersonas _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAUnidadTrabajoPersonas> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAUnidadTrabajoPersonas>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdUnidadTrabajo, IdUnidadTrabajoProceso, IdUnidadPersona, IdClienteProceso, Nombre, IdDocumentoBIA, IdProceso FROM tblBIAUnidadTrabajoPersonas ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAUnidadTrabajoPersonas>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAUnidadTrabajoPersonas entity)
        {
            var sql = "UPDATE tblBIAUnidadTrabajoPersonas SET IdEmpresa = @idempresa, IdUnidadTrabajo = @idunidadtrabajo, IdUnidadTrabajoProceso = @idunidadtrabajoproceso, , IdClienteProceso = @idclienteproceso, Nombre = @nombre, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso WHERE IdEmpresa = @idempresa AND IdUnidadTrabajo = @idunidadtrabajo AND IdUnidadTrabajoProceso = @idunidadtrabajoproceso AND IdUnidadPersona = @idunidadpersona AND IdClienteProceso = @idclienteproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdUnidadTrabajo = entity.IdUnidadTrabajo, IdUnidadTrabajoProceso = entity.IdUnidadTrabajoProceso, IdUnidadPersona = entity.IdUnidadPersona, IdClienteProceso = entity.IdClienteProceso });
                return _affectedRows;
            }
        }
    }
}
