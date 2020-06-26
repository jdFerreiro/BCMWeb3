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
    public class BIAInterdependenciaRepository : IBIAInterdependenciaRepository
    {
        private readonly IConfiguration _configuration;

        public BIAInterdependenciaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAInterdependencia entity)
        {
            var sql = "INSERT INTO tblBIAInterdependencia (IdEmpresa, IdDocumentoBIA, IdProceso, , Organizacion, Servicio, Contacto) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Organizacion, @Servicio, @Contacto);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idinterdependencia)
        {
            var sql = "DELETE FROM tblBIAInterdependencia WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdInterdependencia = @idinterdependencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdInterdependencia = idinterdependencia });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAInterdependencia> Get(long idempresa, long iddocumentobia, long idproceso, long idinterdependencia)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdInterdependencia, Organizacion, Servicio, Contacto FROM tblBIAInterdependencia  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdInterdependencia = @idinterdependencia;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAInterdependencia>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdInterdependencia = idinterdependencia });
                BIAInterdependencia _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAInterdependencia> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAInterdependencia>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdInterdependencia, Organizacion, Servicio, Contacto FROM tblBIAInterdependencia ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAInterdependencia>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAInterdependencia entity)
        {
            var sql = "UPDATE tblBIAInterdependencia SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Organizacion = @organizacion, Servicio = @servicio, Contacto = @contacto WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdInterdependencia = @idinterdependencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdInterdependencia = entity.IdInterdependencia });
                return _affectedRows;
            }
        }
    }
}
