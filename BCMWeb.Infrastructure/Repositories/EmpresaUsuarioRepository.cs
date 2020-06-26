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
    public class EmpresaUsuarioRepository : IEmpresaUsuarioRepository
    {
        private readonly IConfiguration _configuration;

        public EmpresaUsuarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(EmpresaUsuario entity)
        {
            var sql = "INSERT INTO tblEmpresaUsuario (IdEmpresa, IdUsuario, FechaCreacion, IdNivelUsuario) VALUES(@IdEmpresa, @IdUsuario, @FechaCreacion, @IdNivelUsuario);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idusuario)
        {
            var sql = "DELETE FROM tblEmpresaUsuario WHERE IdEmpresa = @idempresa AND IdUsuario = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdUsuario = idusuario });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<EmpresaUsuario> Get(long idempresa, long idusuario)
        {
            var sql = "SELECT IdEmpresa, IdUsuario, FechaCreacion, IdNivelUsuario FROM tblEmpresaUsuario  WHERE IdEmpresa = @idempresa AND IdUsuario = @idusuario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EmpresaUsuario>(sql, new { IdEmpresa = idempresa, IdUsuario = idusuario });
                EmpresaUsuario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<EmpresaUsuario> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<EmpresaUsuario>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdUsuario, FechaCreacion, IdNivelUsuario FROM tblEmpresaUsuario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<EmpresaUsuario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(EmpresaUsuario entity)
        {
            var sql = "UPDATE tblEmpresaUsuario SET IdEmpresa = @idempresa, IdUsuario = @idusuario, FechaCreacion = @fechacreacion, IdNivelUsuario = @idnivelusuario WHERE IdEmpresa = @idempresa AND IdUsuario = @idusuario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdUsuario = entity.IdUsuario });
                return _affectedRows;
            }
        }
    }
}
