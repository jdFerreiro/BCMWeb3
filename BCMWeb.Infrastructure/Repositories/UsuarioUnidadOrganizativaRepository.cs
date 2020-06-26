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

        public async Task<long> Add(UsuarioUnidadOrganizativa entity)
        {
            var sql = "INSERT INTO tblUsuarioUnidadOrganizativa (IdEmpresa, IdUnidadOrganizativa, IdUsuario, IdNivelUsuario) VALUES(@IdEmpresa, @IdUnidadOrganizativa, @IdUsuario, @IdNivelUsuario);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idunidadorganizativa, long idusuario)
        {
            var sql = "DELETE FROM tblUsuarioUnidadOrganizativa WHERE IdEmpresa = @idempresa AND IdUnidadOrganizativa = @idunidadorganizativa AND IdUsuario = @idusuario;";
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

        public async Task<UsuarioUnidadOrganizativa> Get(long idempresa, long idunidadorganizativa, long idusuario)
        {
            var sql = "SELECT IdEmpresa, IdUnidadOrganizativa, IdUsuario, IdNivelUsuario FROM tblUsuarioUnidadOrganizativa  WHERE IdEmpresa = @idempresa AND IdUnidadOrganizativa = @idunidadorganizativa AND IdUsuario = @idusuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<UsuarioUnidadOrganizativa>(sql, new { IdEmpresa = idempresa, IdUnidadOrganizativa = idunidadorganizativa, IdUsuario = idusuario });
                UsuarioUnidadOrganizativa _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<UsuarioUnidadOrganizativa> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<UsuarioUnidadOrganizativa>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdUnidadOrganizativa, IdUsuario, IdNivelUsuario FROM tblUsuarioUnidadOrganizativa ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<UsuarioUnidadOrganizativa>(sql);
                return _result;
            }

        }
        public async Task<long> Update(UsuarioUnidadOrganizativa entity)
        {
            var sql = "UPDATE tblUsuarioUnidadOrganizativa SET IdEmpresa = @idempresa, IdUnidadOrganizativa = @idunidadorganizativa, IdUsuario = @idusuario, IdNivelUsuario = @idnivelusuario WHERE IdEmpresa = @idempresa AND IdUnidadOrganizativa = @idunidadorganizativa AND IdUsuario = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdUnidadOrganizativa = entity.IdUnidadOrganizativa, IdUsuario = entity.IdUsuario });
                return _affectedRows;
            }
        }
    }
}
