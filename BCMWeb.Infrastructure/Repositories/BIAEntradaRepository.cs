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
    public class BIAEntradaRepository : IBIAEntradaRepository
    {
        private readonly IConfiguration _configuration;

        public BIAEntradaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAEntrada entity)
        {
            var sql = "INSERT INTO tblBIAEntrada (IdEmpresa, IdDocumentoBIA, IdProceso, , Unidad, Evento, Responsable) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Unidad, @Evento, @Responsable);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long identrada)
        {
            var sql = "DELETE FROM tblBIAEntrada WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdEntrada = @identrada;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdEntrada = identrada });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAEntrada> Get(long idempresa, long iddocumentobia, long idproceso, long identrada)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdEntrada, Unidad, Evento, Responsable FROM tblBIAEntrada  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdEntrada = @identrada;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAEntrada>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdEntrada = identrada });
                BIAEntrada _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAEntrada> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAEntrada>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdEntrada, Unidad, Evento, Responsable FROM tblBIAEntrada ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAEntrada>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAEntrada entity)
        {
            var sql = "UPDATE tblBIAEntrada SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Unidad = @unidad, Evento = @evento, Responsable = @responsable WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdEntrada = @identrada;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdEntrada = entity.IdEntrada });
                return _affectedRows;
            }
        }
    }
}
