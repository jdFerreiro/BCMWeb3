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
    public class BIAImpactoFinancieroRepository : IBIAImpactoFinancieroRepository
    {
        private readonly IConfiguration _configuration;

        public BIAImpactoFinancieroRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAImpactoFinanciero entity)
        {
            var sql = "INSERT INTO tblBIAImpactoFinanciero (IdEmpresa, IdDocumentoBIA, IdProceso, , IdTipoFrecuencia, Descripcion, Impacto, IdEscala, UnidadTiempo) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @IdTipoFrecuencia, @Descripcion, @Impacto, @IdEscala, @UnidadTiempo);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idimpactofinanciero)
        {
            var sql = "DELETE FROM tblBIAImpactoFinanciero WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdImpactoFinanciero = @idimpactofinanciero;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdImpactoFinanciero = idimpactofinanciero });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAImpactoFinanciero> Get(long idempresa, long iddocumentobia, long idproceso, long idimpactofinanciero)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdImpactoFinanciero, IdTipoFrecuencia, Descripcion, Impacto, IdEscala, UnidadTiempo FROM tblBIAImpactoFinanciero  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdImpactoFinanciero = @idimpactofinanciero;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAImpactoFinanciero>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdImpactoFinanciero = idimpactofinanciero });
                BIAImpactoFinanciero _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAImpactoFinanciero> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAImpactoFinanciero>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdImpactoFinanciero, IdTipoFrecuencia, Descripcion, Impacto, IdEscala, UnidadTiempo FROM tblBIAImpactoFinanciero ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAImpactoFinanciero>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAImpactoFinanciero entity)
        {
            var sql = "UPDATE tblBIAImpactoFinanciero SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , IdTipoFrecuencia = @idtipofrecuencia, Descripcion = @descripcion, Impacto = @impacto, IdEscala = @idescala, UnidadTiempo = @unidadtiempo WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdImpactoFinanciero = @idimpactofinanciero;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdImpactoFinanciero = entity.IdImpactoFinanciero });
                return _affectedRows;
            }
        }
    }
}
