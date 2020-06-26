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
    public class BIAAmenazaEventoRepository : IBIAAmenazaEventoRepository
    {
        private readonly IConfiguration _configuration;

        public BIAAmenazaEventoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAAmenazaEvento entity)
        {
            var sql = "INSERT INTO tblBIAAmenazaEvento (IdEmpresa, IdDocumentoBIA, IdProceso, IdAmenaza, , Nombre, IdEventoRiesgo) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, @IdAmenaza, , @Nombre, @IdEventoRiesgo);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento)
        {
            var sql = "DELETE FROM tblBIAAmenazaEvento WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdAmenaza = @idamenaza AND IdAmenazaEvento = @idamenazaevento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdAmenaza = idamenaza, IdAmenazaEvento = idamenazaevento });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAAmenazaEvento> Get(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdAmenaza, IdAmenazaEvento, Nombre, IdEventoRiesgo FROM tblBIAAmenazaEvento  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdAmenaza = @idamenaza AND IdAmenazaEvento = @idamenazaevento;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAAmenazaEvento>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdAmenaza = idamenaza, IdAmenazaEvento = idamenazaevento });
                BIAAmenazaEvento _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAAmenazaEvento> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAAmenazaEvento>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdAmenaza, IdAmenazaEvento, Nombre, IdEventoRiesgo FROM tblBIAAmenazaEvento ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAAmenazaEvento>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAAmenazaEvento entity)
        {
            var sql = "UPDATE tblBIAAmenazaEvento SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, IdAmenaza = @idamenaza, , Nombre = @nombre, IdEventoRiesgo = @ideventoriesgo WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdAmenaza = @idamenaza AND IdAmenazaEvento = @idamenazaevento;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdAmenaza = entity.IdAmenaza, IdAmenazaEvento = entity.IdAmenazaEvento });
                return _affectedRows;
            }
        }
    }
}
