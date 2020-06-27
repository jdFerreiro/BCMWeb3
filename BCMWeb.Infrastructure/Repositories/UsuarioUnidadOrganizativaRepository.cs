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

        public async Task<long> Add(TblUsuarioUnidadOrganizativa entity)
        {
            var sql = "INSERT INTO tblUsuarioUnidadOrganizativa (IdEmpresa, IdUnidadOrganizativa, UserId, IdNivelUsuario) VALUES(@IdEmpresa, @IdUnidadOrganizativa, @UserId, @IdNivelUsuario);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idunidadorganizativa, long idusuario)
        {
            var sql = "DELETE FROM tblUsuarioUnidadOrganizativa WHERE IdEmpresa = @idempresa AND IdUnidadOrganizativa = @idunidadorganizativa AND UserId = @idusuario;";
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

        public async Task<TblUsuarioUnidadOrganizativa> Get(long idempresa, long idunidadorganizativa, long idusuario)
        {
            var sql = "SELECT IdEmpresa, IdUnidadOrganizativa, UserId, IdNivelUsuario FROM tblUsuarioUnidadOrganizativa  WHERE IdEmpresa = @idempresa AND IdUnidadOrganizativa = @idunidadorganizativa AND UserId = @idusuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TblUsuarioUnidadOrganizativa>(sql, new { IdEmpresa = idempresa, IdUnidadOrganizativa = idunidadorganizativa, IdUsuario = idusuario });
                TblUsuarioUnidadOrganizativa _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<TblUsuarioUnidadOrganizativa> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TblUsuarioUnidadOrganizativa>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdUnidadOrganizativa, UserId, IdNivelUsuario FROM tblUsuarioUnidadOrganizativa ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<TblUsuarioUnidadOrganizativa>(sql);
                return _result;
            }

        }
        public async Task<long> Update(TblUsuarioUnidadOrganizativa entity)
        {
            var sql = "UPDATE tblUsuarioUnidadOrganizativa SET IdEmpresa = @idempresa, IdUnidadOrganizativa = @idunidadorganizativa, UserId = @idusuario, IdNivelUsuario = @idnivelusuario WHERE IdEmpresa = @idempresa AND IdUnidadOrganizativa = @idunidadorganizativa AND UserId = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { entity.IdEmpresa, entity.IdUnidadOrganizativa, entity.IdUsuario });
                return _affectedRows;
            }
        }
    }
}
