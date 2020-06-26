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
    public class BIAProcesoAlternoRepository : IBIAProcesoAlternoRepository
    {
        private readonly IConfiguration _configuration;

        public BIAProcesoAlternoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAProcesoAlterno entity)
        {
            var sql = "INSERT INTO tblBIAProcesoAlterno (IdEmpresa, IdDocumentoBIA, IdProceso, , ProcesoAlterno) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @ProcesoAlterno);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idprocesoalterno)
        {
            var sql = "DELETE FROM tblBIAProcesoAlterno WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdProcesoAlterno = @idprocesoalterno;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdProcesoAlterno = idprocesoalterno });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAProcesoAlterno> Get(long idempresa, long iddocumentobia, long idproceso, long idprocesoalterno)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdProcesoAlterno, ProcesoAlterno FROM tblBIAProcesoAlterno  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdProcesoAlterno = @idprocesoalterno;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAProcesoAlterno>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdProcesoAlterno = idprocesoalterno });
                BIAProcesoAlterno _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAProcesoAlterno> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAProcesoAlterno>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdProcesoAlterno, ProcesoAlterno FROM tblBIAProcesoAlterno ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAProcesoAlterno>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAProcesoAlterno entity)
        {
            var sql = "UPDATE tblBIAProcesoAlterno SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , ProcesoAlterno = @procesoalterno WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdProcesoAlterno = @idprocesoalterno;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdProcesoAlterno = entity.IdProcesoAlterno });
                return _affectedRows;
            }
        }
    }
}
