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
    public class BIAEventoControlRepository : IBIAEventoControlRepository
    {
        private readonly IConfiguration _configuration;

        public BIAEventoControlRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAEventoControl entity)
        {
            var sql = "INSERT INTO tblBIAEventoControl (IdEmpresa, IdDocumentoBIA, IdProceso, IdAmenaza, IdAmenazaEvento, , Descripcion, Implantado) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, @IdAmenaza, @IdAmenazaEvento, , @Descripcion, @Implantado);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento, long ideventocontrol)
        {
            var sql = "DELETE FROM tblBIAEventoControl WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdAmenaza = @idamenaza AND IdAmenazaEvento = @idamenazaevento AND IdEventoControl = @ideventocontrol;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdAmenaza = idamenaza, IdAmenazaEvento = idamenazaevento, IdEventoControl = ideventocontrol });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAEventoControl> Get(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento, long ideventocontrol)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdAmenaza, IdAmenazaEvento, IdEventoControl, Descripcion, Implantado FROM tblBIAEventoControl  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdAmenaza = @idamenaza AND IdAmenazaEvento = @idamenazaevento AND IdEventoControl = @ideventocontrol;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAEventoControl>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdAmenaza = idamenaza, IdAmenazaEvento = idamenazaevento, IdEventoControl = ideventocontrol });
                BIAEventoControl _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAEventoControl> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAEventoControl>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdAmenaza, IdAmenazaEvento, IdEventoControl, Descripcion, Implantado FROM tblBIAEventoControl ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAEventoControl>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAEventoControl entity)
        {
            var sql = "UPDATE tblBIAEventoControl SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, IdAmenaza = @idamenaza, IdAmenazaEvento = @idamenazaevento, , Descripcion = @descripcion, Implantado = @implantado WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdAmenaza = @idamenaza AND IdAmenazaEvento = @idamenazaevento AND IdEventoControl = @ideventocontrol;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdAmenaza = entity.IdAmenaza, IdAmenazaEvento = entity.IdAmenazaEvento, IdEventoControl = entity.IdEventoControl });
                return _affectedRows;
            }
        }
    }
}
