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
    public class BIAWRTRepository : IBIAWRTRepository
    {
        private readonly IConfiguration _configuration;

        public BIAWRTRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAWRT entity)
        {
            var sql = "INSERT INTO tblBIAWRT (IdEmpresa, IdDocumentoBIA, IdProceso, , Observacion, IdTipoFrecuencia, IdEscala) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Observacion, @IdTipoFrecuencia, @IdEscala);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idwrt)
        {
            var sql = "DELETE FROM tblBIAWRT WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdWRT = @idwrt;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdWRT = idwrt });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAWRT> Get(long idempresa, long iddocumentobia, long idproceso, long idwrt)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdWRT, Observacion, IdTipoFrecuencia, IdEscala FROM tblBIAWRT  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdWRT = @idwrt;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAWRT>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdWRT = idwrt });
                BIAWRT _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAWRT> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAWRT>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdWRT, Observacion, IdTipoFrecuencia, IdEscala FROM tblBIAWRT ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAWRT>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAWRT entity)
        {
            var sql = "UPDATE tblBIAWRT SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Observacion = @observacion, IdTipoFrecuencia = @idtipofrecuencia, IdEscala = @idescala WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdWRT = @idwrt;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdWRT = entity.IdWRT });
                return _affectedRows;
            }
        }
    }
}
