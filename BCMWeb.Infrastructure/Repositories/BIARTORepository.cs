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
    public class BIARTORepository : IBIARTORepository
    {
        private readonly IConfiguration _configuration;

        public BIARTORepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIARTO entity)
        {
            var sql = "INSERT INTO tblBIARTO (IdEmpresa, IdDocumentoBIA, IdProceso, , Observacion, IdTipoFrecuencia, IdEscala) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Observacion, @IdTipoFrecuencia, @IdEscala);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrto)
        {
            var sql = "DELETE FROM tblBIARTO WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdRTO = @idrto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdRTO = idrto });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIARTO> Get(long idempresa, long iddocumentobia, long idproceso, long idrto)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdRTO, Observacion, IdTipoFrecuencia, IdEscala FROM tblBIARTO  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdRTO = @idrto;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIARTO>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdRTO = idrto });
                BIARTO _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIARTO> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIARTO>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdRTO, Observacion, IdTipoFrecuencia, IdEscala FROM tblBIARTO ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIARTO>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIARTO entity)
        {
            var sql = "UPDATE tblBIARTO SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Observacion = @observacion, IdTipoFrecuencia = @idtipofrecuencia, IdEscala = @idescala WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdRTO = @idrto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdRTO = entity.IdRTO });
                return _affectedRows;
            }
        }
    }
}
