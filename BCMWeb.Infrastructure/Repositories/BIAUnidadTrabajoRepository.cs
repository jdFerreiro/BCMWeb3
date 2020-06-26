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
    public class BIAUnidadTrabajoRepository : IBIAUnidadTrabajoRepository
    {
        private readonly IConfiguration _configuration;

        public BIAUnidadTrabajoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAUnidadTrabajo entity)
        {
            var sql = "INSERT INTO tblBIAUnidadTrabajo (IdEmpresa, , Nombre, IdUnidadOrganizativa) VALUES(@IdEmpresa, , @Nombre, @IdUnidadOrganizativa);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idunidadtrabajo)
        {
            var sql = "DELETE FROM tblBIAUnidadTrabajo WHERE IdEmpresa = @idempresa AND IdUnidadTrabajo = @idunidadtrabajo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdUnidadTrabajo = idunidadtrabajo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAUnidadTrabajo> Get(long idempresa, long idunidadtrabajo)
        {
            var sql = "SELECT IdEmpresa, IdUnidadTrabajo, Nombre, IdUnidadOrganizativa FROM tblBIAUnidadTrabajo  WHERE IdEmpresa = @idempresa AND IdUnidadTrabajo = @idunidadtrabajo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAUnidadTrabajo>(sql, new { IdEmpresa = idempresa, IdUnidadTrabajo = idunidadtrabajo });
                BIAUnidadTrabajo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAUnidadTrabajo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAUnidadTrabajo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdUnidadTrabajo, Nombre, IdUnidadOrganizativa FROM tblBIAUnidadTrabajo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAUnidadTrabajo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAUnidadTrabajo entity)
        {
            var sql = "UPDATE tblBIAUnidadTrabajo SET IdEmpresa = @idempresa, , Nombre = @nombre, IdUnidadOrganizativa = @idunidadorganizativa WHERE IdEmpresa = @idempresa AND IdUnidadTrabajo = @idunidadtrabajo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdUnidadTrabajo = entity.IdUnidadTrabajo });
                return _affectedRows;
            }
        }
    }
}
