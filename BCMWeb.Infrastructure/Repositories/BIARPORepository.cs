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
    public class BIARPORepository : IBIARPORepository
    {
        private readonly IConfiguration _configuration;

        public BIARPORepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIARPO entity)
        {
            var sql = "INSERT INTO tblBIARPO (IdEmpresa, IdDocumentoBIA, IdProceso, , Observacion, IdTipoFrecuencia, IdEscala) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Observacion, @IdTipoFrecuencia, @IdEscala);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrpo)
        {
            var sql = "DELETE FROM tblBIARPO WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdRPO = @idrpo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdRPO = idrpo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIARPO> Get(long idempresa, long iddocumentobia, long idproceso, long idrpo)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdRPO, Observacion, IdTipoFrecuencia, IdEscala FROM tblBIARPO  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdRPO = @idrpo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIARPO>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdRPO = idrpo });
                BIARPO _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIARPO> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIARPO>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdRPO, Observacion, IdTipoFrecuencia, IdEscala FROM tblBIARPO ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIARPO>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIARPO entity)
        {
            var sql = "UPDATE tblBIARPO SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Observacion = @observacion, IdTipoFrecuencia = @idtipofrecuencia, IdEscala = @idescala WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdRPO = @idrpo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdRPO = entity.IdRPO });
                return _affectedRows;
            }
        }
    }
}
