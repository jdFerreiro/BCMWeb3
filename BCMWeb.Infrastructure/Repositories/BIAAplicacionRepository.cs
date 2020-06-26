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
    public class BIAAplicacionRepository : IBIAAplicacionRepository
    {
        private readonly IConfiguration _configuration;

        public BIAAplicacionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAAplicacion entity)
        {
            var sql = "INSERT INTO tblBIAAplicacion (IdEmpresa, IdDocumentoBIA, IdProceso, , Nombre, Usuario) VALUES(@IdEmpresa, @IdDocumentoBIA, @IdProceso, , @Nombre, @Usuario);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idaplicacion)
        {
            var sql = "DELETE FROM tblBIAAplicacion WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdAplicacion = @idaplicacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdAplicacion = idaplicacion });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAAplicacion> Get(long idempresa, long iddocumentobia, long idproceso, long idaplicacion)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdAplicacion, Nombre, Usuario FROM tblBIAAplicacion  WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdAplicacion = @idaplicacion;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAAplicacion>(sql, new { IdEmpresa = idempresa, IdDocumentoBIA = iddocumentobia, IdProceso = idproceso, IdAplicacion = idaplicacion });
                BIAAplicacion _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAAplicacion> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAAplicacion>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBIA, IdProceso, IdAplicacion, Nombre, Usuario FROM tblBIAAplicacion ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAAplicacion>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAAplicacion entity)
        {
            var sql = "UPDATE tblBIAAplicacion SET IdEmpresa = @idempresa, IdDocumentoBIA = @iddocumentobia, IdProceso = @idproceso, , Nombre = @nombre, Usuario = @usuario WHERE IdEmpresa = @idempresa AND IdDocumentoBIA = @iddocumentobia AND IdProceso = @idproceso AND IdAplicacion = @idaplicacion;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBIA = entity.IdDocumentoBIA, IdProceso = entity.IdProceso, IdAplicacion = entity.IdAplicacion });
                return _affectedRows;
            }
        }
    }
}
