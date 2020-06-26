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
    public class BIAGranImpactoRepository : IBIAGranImpactoRepository
    {
        private readonly IConfiguration _configuration;

        public BIAGranImpactoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAGranImpacto entity)
        {
            var sql = "INSERT INTO tblBIAGranImpacto (IdEmpresa, IdDocumentoBIA, IdProceso, , IdMes, Observacion, Explicacion) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @IdMes, @Observacion, @Explicacion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idgranimpacto, int idmes)
        {
            var sql = "DELETE FROM tblBIAGranImpacto WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdGranImpacto = @idgranimpacto AND IdMes = @idmes;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdGranImpacto = idgranimpacto, IdMes = idmes });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAGranImpacto> Get(long idempresa, long iddocumentobia, long idproceso, long idgranimpacto, int idmes)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdGranImpacto, IdMes, Observacion, Explicacion FROM tblBIAGranImpacto  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdGranImpacto = @idgranimpacto AND IdMes = @idmes;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAGranImpacto>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdGranImpacto = idgranimpacto, IdMes = idmes });
                BIAGranImpacto _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAGranImpacto> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAGranImpacto>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdGranImpacto, IdMes, Observacion, Explicacion FROM tblBIAGranImpacto ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAGranImpacto>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAGranImpacto entity)
        {
            var sql = "UPDATE tblBIAGranImpacto SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , IdMes = @idmes, Observacion = @observacion, Explicacion = @explicacion WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdGranImpacto = @idgranimpacto AND IdMes = @idmes;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdGranImpacto = entity.IdGranImpacto, IdMes = entity.IdMes });
                return _affectedRows;
            }
        }
    }
}
