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
    public class UnidadOrganizativaRepository : IUnidadOrganizativaRepository
    {
        private readonly IConfiguration _configuration;

        public UnidadOrganizativaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(UnidadOrganizativa entity)
        {
            var sql = "INSERT INTO tblUnidadOrganizativa (IdEmpresa, , Nombre, IdUnidadPadre) VALUES(@IdEmpresa, , @Nombre, @IdUnidadPadre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idunidadorganizativa)
        {
            var sql = "DELETE FROM tblUnidadOrganizativa WHERE IdEmpresa = @idempresa AND IdUnidadOrganizativa = @idunidadorganizativa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdUnidadOrganizativa = idunidadorganizativa });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<UnidadOrganizativa> Get(long idempresa, long idunidadorganizativa)
        {
            var sql = "SELECT IdEmpresa, IdUnidadOrganizativa, Nombre, IdUnidadPadre FROM tblUnidadOrganizativa  WHERE IdEmpresa = @idempresa AND IdUnidadOrganizativa = @idunidadorganizativa;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<UnidadOrganizativa>(sql, new { IdEmpresa = idempresa, IdUnidadOrganizativa = idunidadorganizativa });
                UnidadOrganizativa _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<UnidadOrganizativa> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<UnidadOrganizativa>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdUnidadOrganizativa, Nombre, IdUnidadPadre FROM tblUnidadOrganizativa ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<UnidadOrganizativa>(sql);
                return _result;
            }

        }
        public async Task<long> Update(UnidadOrganizativa entity)
        {
            var sql = "UPDATE tblUnidadOrganizativa SET IdEmpresa = @idempresa, , Nombre = @nombre, IdUnidadPadre = @idunidadpadre WHERE IdEmpresa = @idempresa AND IdUnidadOrganizativa = @idunidadorganizativa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdUnidadOrganizativa = entity.IdUnidadOrganizativa });
                return _affectedRows;
            }
        }
    }
}
