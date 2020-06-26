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
    public class BIAProcesoRepository : IBIAProcesoRepository
    {
        private readonly IConfiguration _configuration;

        public BIAProcesoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAProceso entity)
        {
            var sql = "INSERT INTO tblBIAProceso (IdEmpresa, IdDocumentoBia, , Nombre, Descripcion, NroProceso, FechaCreacion, IdUnidadOrganizativa, Critico, IdEstadoProceso, FechaUltimoEstatus) VALUES(@IdEmpresa, @IdDocumentoBia, , @Nombre, @Descripcion, @NroProceso, @FechaCreacion, @IdUnidadOrganizativa, @Critico, @IdEstadoProceso, @FechaUltimoEstatus);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso)
        {
            var sql = "DELETE FROM tblBIAProceso WHERE IdEmpresa = @idempresa AND IdDocumentoBia = @iddocumentobia AND IdProceso = @idproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBia = iddocumentobia, IdProceso = idproceso });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAProceso> Get(long idempresa, long iddocumentobia, long idproceso)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBia, IdProceso, Nombre, Descripcion, NroProceso, FechaCreacion, IdUnidadOrganizativa, Critico, IdEstadoProceso, FechaUltimoEstatus FROM tblBIAProceso  WHERE IdEmpresa = @idempresa AND IdDocumentoBia = @iddocumentobia AND IdProceso = @idproceso;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAProceso>(sql, new { IdEmpresa = idempresa, IdDocumentoBia = iddocumentobia, IdProceso = idproceso });
                BIAProceso _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAProceso> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAProceso>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBia, IdProceso, Nombre, Descripcion, NroProceso, FechaCreacion, IdUnidadOrganizativa, Critico, IdEstadoProceso, FechaUltimoEstatus FROM tblBIAProceso ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAProceso>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAProceso entity)
        {
            var sql = "UPDATE tblBIAProceso SET IdEmpresa = @idempresa, IdDocumentoBia = @iddocumentobia, , Nombre = @nombre, Descripcion = @descripcion, NroProceso = @nroproceso, FechaCreacion = @fechacreacion, IdUnidadOrganizativa = @idunidadorganizativa, Critico = @critico, IdEstadoProceso = @idestadoproceso, FechaUltimoEstatus = @fechaultimoestatus WHERE IdEmpresa = @idempresa AND IdDocumentoBia = @iddocumentobia AND IdProceso = @idproceso;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBia = entity.IdDocumentoBia, IdProceso = entity.IdProceso });
                return _affectedRows;
            }
        }
    }
}
