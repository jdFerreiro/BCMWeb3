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
    public class BIAMTDRepository : IBIAMTDRepository
    {
        private readonly IConfiguration _configuration;

        public BIAMTDRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAMTD entity)
        {
            var sql = "INSERT INTO tblBIAMTD (IdEmpresa, IdDocumentoBIA, IdProceso, , Observacion, IdTipoFrecuencia, IdEscala) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Observacion, @IdTipoFrecuencia, @IdEscala);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idmtd)
        {
            var sql = "DELETE FROM tblBIAMTD WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdMTD = @idmtd;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdMTD = idmtd });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAMTD> Get(long idempresa, long iddocumentobia, long idproceso, long idmtd)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdMTD, Observacion, IdTipoFrecuencia, IdEscala FROM tblBIAMTD  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdMTD = @idmtd;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAMTD>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdMTD = idmtd });
                BIAMTD _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAMTD> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAMTD>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdMTD, Observacion, IdTipoFrecuencia, IdEscala FROM tblBIAMTD ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAMTD>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAMTD entity)
        {
            var sql = "UPDATE tblBIAMTD SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Observacion = @observacion, IdTipoFrecuencia = @idtipofrecuencia, IdEscala = @idescala WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdMTD = @idmtd;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdMTD = entity.IdMTD });
                return _affectedRows;
            }
        }
    }
}
