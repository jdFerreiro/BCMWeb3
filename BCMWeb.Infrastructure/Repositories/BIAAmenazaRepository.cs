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
    public class BIAAmenazaRepository : IBIAAmenazaRepository
    {
        private readonly IConfiguration _configuration;

        public BIAAmenazaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAAmenaza entity)
        {
            var sql = "INSERT INTO tblBIAAmenaza (IdEmpresa, IdDocumento, IdProceso, , IdDocumentoBIA, IdTipoDocumento, Descripcion, Evento, TipoControlImplantado, ControlesImplantar, Probabilidad, Impacto, Control, Severidad, Fuente, Estado) VALUES(@IdEmpresa, @IdDocumento, @IdProceso, , @IdDocumentoBIA, @IdTipoDocumento, @Descripcion, @Evento, @TipoControlImplantado, @ControlesImplantar, @Probabilidad, @Impacto, @Control, @Severidad, @Fuente, @Estado);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idproceso, long idamenaza)
        {
            var sql = "DELETE FROM tblBIAAmenaza WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdProceso = @idproceso AND IdAmenaza = @idamenaza;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdProceso = idproceso, IdAmenaza = idamenaza });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAAmenaza> Get(long idempresa, long iddocumento, long idproceso, long idamenaza)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdProceso, IdAmenaza, IdDocumentoBIA, IdTipoDocumento, Descripcion, Evento, TipoControlImplantado, ControlesImplantar, Probabilidad, Impacto, Control, Severidad, Fuente, Estado FROM tblBIAAmenaza  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdProceso = @idproceso AND IdAmenaza = @idamenaza;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAAmenaza>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdProceso = idproceso, IdAmenaza = idamenaza });
                BIAAmenaza _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAAmenaza> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAAmenaza>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdProceso, IdAmenaza, IdDocumentoBIA, IdTipoDocumento, Descripcion, Evento, TipoControlImplantado, ControlesImplantar, Probabilidad, Impacto, Control, Severidad, Fuente, Estado FROM tblBIAAmenaza ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAAmenaza>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAAmenaza entity)
        {
            var sql = "UPDATE tblBIAAmenaza SET IdEmpresa = @idempresa, IdDocumento = @iddocumento, IdProceso = @idproceso, , IdDocumentoBIA = @iddocumentobia, IdTipoDocumento = @idtipodocumento, Descripcion = @descripcion, Evento = @evento, TipoControlImplantado = @tipocontrolimplantado, ControlesImplantar = @controlesimplantar, Probabilidad = @probabilidad, Impacto = @impacto, Control = @control, Severidad = @severidad, Fuente = @fuente, Estado = @estado WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdProceso = @idproceso AND IdAmenaza = @idamenaza;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdProceso = entity.IdProceso, IdAmenaza = entity.IdAmenaza });
                return _affectedRows;
            }
        }
    }
}
