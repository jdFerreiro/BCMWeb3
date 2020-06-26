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
    public class BIAImpactoOperacionalRepository : IBIAImpactoOperacionalRepository
    {
        private readonly IConfiguration _configuration;

        public BIAImpactoOperacionalRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAImpactoOperacional entity)
        {
            var sql = "INSERT INTO tblBIAImpactoOperacional (IdEmpresa, IdDocumentoBIA, IdProceso, , IdTipoFrecuencia, ImpactoOperacional, Descripcion, IdEscala, UnidadTiempo) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @IdTipoFrecuencia, @ImpactoOperacional, @Descripcion, @IdEscala, @UnidadTiempo);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idimpactooperacional)
        {
            var sql = "DELETE FROM tblBIAImpactoOperacional WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdImpactoOperacional = @idimpactooperacional;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdImpactoOperacional = idimpactooperacional });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAImpactoOperacional> Get(long idempresa, long iddocumentobia, long idproceso, long idimpactooperacional)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdImpactoOperacional, IdTipoFrecuencia, ImpactoOperacional, Descripcion, IdEscala, UnidadTiempo FROM tblBIAImpactoOperacional  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdImpactoOperacional = @idimpactooperacional;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAImpactoOperacional>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdImpactoOperacional = idimpactooperacional });
                BIAImpactoOperacional _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAImpactoOperacional> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAImpactoOperacional>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdImpactoOperacional, IdTipoFrecuencia, ImpactoOperacional, Descripcion, IdEscala, UnidadTiempo FROM tblBIAImpactoOperacional ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAImpactoOperacional>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAImpactoOperacional entity)
        {
            var sql = "UPDATE tblBIAImpactoOperacional SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , IdTipoFrecuencia = @idtipofrecuencia, ImpactoOperacional = @impactooperacional, Descripcion = @descripcion, IdEscala = @idescala, UnidadTiempo = @unidadtiempo WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdImpactoOperacional = @idimpactooperacional;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdImpactoOperacional = entity.IdImpactoOperacional });
                return _affectedRows;
            }
        }
    }
}
