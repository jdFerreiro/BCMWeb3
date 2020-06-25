using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class AuditoriaRepository : IAuditoriaRepository
    {
        private readonly IConfiguration _configuration;

        public AuditoriaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Auditoria entity)
        {
            var sql = @"INSERT INTO tblAuditoria (IdEmpresa, IdDocumento, IdTipoDocumento, FechaRegistro, DireccionIP, 
                                                  Mensaje, Accion, IdUsuario, Negocios, DatosModificados)
                        VALUES(@IdEmpresa, @IdDocumento, @IdTipoDocumento, @FechaRegistro, @DireccionIP, @Mensaje, @Accion, 
                                           @IdUsuario, @Negocios, @DatosModificados);";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long id)
        {
            var sql = @"DELETE FROM tblAuditoria WHERE IdAuditoria = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return _affectedRows;
            }
        }
        public async Task<long> DeleteFromEmpresa(long idEmpresa)
        {
            var sql = @"DELETE FROM tblAuditoria WHERE IdEmpresa = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = idEmpresa });
                return _affectedRows;
            }
        }
        public async Task<Auditoria> Get(long id)
        {
            var sql = @"SELECT IdAuditoria, IdEmpresa, IdDocumento, IdTipoDocumento, FechaRegistro, DireccionIP, Mensaje, 
                               Accion, IdUsuario, Negocios, DatosModificados
                        FROM tblAuditoria WHERE IdAuditoria = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Auditoria>(sql, new { Id = id });
                Auditoria _usuario = _result.FirstOrDefault();
                return _usuario;
            }
        }
        public async Task<IEnumerable<Auditoria>> GetAll(long idEmpresa)
        {
            var sql = @"SELECT IdAuditoria, IdEmpresa, IdDocumento, IdTipoDocumento, FechaRegistro, DireccionIP, Mensaje, 
                               Accion, IdUsuario, Negocios, DatosModificados
                        FROM tblAuditoria WHERE IdEmpresa = @Id";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Auditoria>(sql, new { Id = idEmpresa });
                return _result;
            }
        }
        public Task<IEnumerable<Auditoria>> GetAll()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Auditoria>> GetAllByRangoFechas(long idEmpresa, DateTime startDate, DateTime endDate)
        {
            var sql = @"SELECT IdAuditoria, IdEmpresa, IdDocumento, IdTipoDocumento, FechaRegistro, DireccionIP, Mensaje, 
                               Accion, IdUsuario, Negocios, DatosModificados
                        FROM tblAuditoria WHERE IdEmpresa = @Id AND FechaRegistro BETWEEN @StartDate AND @EndDate";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Auditoria>(sql, new { Id = idEmpresa, StartDate = startDate, EndDate = endDate });
                return _result;
            }
        }
        public async Task<IEnumerable<Auditoria>> GetAllByRangoFechasUsuarioId(long idEmpresa, DateTime startDate, DateTime endDate, long idUsuario)
        {
            var sql = @"SELECT IdAuditoria, IdEmpresa, IdDocumento, IdTipoDocumento, FechaRegistro, DireccionIP, Mensaje, 
                               Accion, IdUsuario, Negocios, DatosModificados
                        FROM tblAuditoria WHERE IdEmpresa = @Id AND IdUsuario = @IdUsuario AND FechaRegistro BETWEEN @StartDate AND @EndDate";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Auditoria>(sql, new { Id = idEmpresa, StartDate = startDate, EndDate = endDate, IdUsuario = idUsuario });
                return _result;
            }
        }
        public async Task<IEnumerable<Auditoria>> GetAllByUsuarioId(long idEmpresa, long idUsuario)
        {
            var sql = @"SELECT IdAuditoria, IdEmpresa, IdDocumento, IdTipoDocumento, FechaRegistro, DireccionIP, Mensaje, 
                               Accion, IdUsuario, Negocios, DatosModificados
                        FROM tblAuditoria WHERE IdEmpresa = @Id AND IdUsuario = @IdUsuario";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Auditoria>(sql, new { Id = idEmpresa, IdUsuario = idUsuario });
                return _result;
            }
        }
        public Task<long> Update(Auditoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
