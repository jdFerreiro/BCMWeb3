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
    public class UsuarioUnidadOrganizativaRepository : IUsuarioUnidadOrganizativaRepository
    {
        private readonly IConfiguration _configuration;

        public UsuarioUnidadOrganizativaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(UserOrganizationUnit entity)
        {
            var sql = "INSERT INTO tblUsuarioUnidadOrganizativa (CompanyId, OrganizationUnitId, UserOwnerId, LevelUserId) VALUES(@CompanyId, @OrganizationUnitId, @UserOwnerId, @LevelUserId);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idunidadorganizativa, long idusuario)
        {
            var sql = "DELETE FROM tblUsuarioUnidadOrganizativa WHERE CompanyId = @idempresa AND OrganizationUnitId = @idunidadorganizativa AND UserOwnerId = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdUnidadOrganizativa = idunidadorganizativa, IdUsuario = idusuario });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<UserOrganizationUnit> Get(long idempresa, long idunidadorganizativa, long idusuario)
        {
            var sql = "SELECT CompanyId, OrganizationUnitId, UserOwnerId, LevelUserId FROM tblUsuarioUnidadOrganizativa  WHERE CompanyId = @idempresa AND OrganizationUnitId = @idunidadorganizativa AND UserOwnerId = @idusuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<UserOrganizationUnit>(sql, new { IdEmpresa = idempresa, IdUnidadOrganizativa = idunidadorganizativa, IdUsuario = idusuario });
                UserOrganizationUnit _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<UserOrganizationUnit> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<UserOrganizationUnit>> GetAll()
        {
            var sql = "SELECT CompanyId, OrganizationUnitId, UserOwnerId, LevelUserId FROM tblUsuarioUnidadOrganizativa ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<UserOrganizationUnit>(sql);
                return _result;
            }

        }
        public async Task<long> Update(UserOrganizationUnit entity)
        {
            var sql = "UPDATE tblUsuarioUnidadOrganizativa SET CompanyId = @idempresa, OrganizationUnitId = @idunidadorganizativa, UserOwnerId = @idusuario, LevelUserId = @idnivelusuario WHERE CompanyId = @idempresa AND OrganizationUnitId = @idunidadorganizativa AND UserOwnerId = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { entity.CompanyId, entity.OrganizationUnitId, entity.UserId });
                return _affectedRows;
            }
        }
    }
}
