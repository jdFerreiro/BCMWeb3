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
    public class ModuloRepository : IModuloRepository
    {
        private readonly IConfiguration _configuration;

        public ModuloRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Modulo entity)
        {
            var sql = "INSERT INTO tblModulo (IdEmpresa, IdModulo, IdCodigoModulo, IdModuloPadre, IdTipoElemento, Nombre, Accion, Controller, Titulo, Descripcion, imageRoot, Activo, Negocios, Tecnologia) VALUES(@IdEmpresa, @IdModulo, @IdCodigoModulo, @IdModuloPadre, @IdTipoElemento, @Nombre, @Accion, @Controller, @Titulo, @Descripcion, @imageRoot, @Activo, @Negocios, @Tecnologia);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idmodulo)
        {
            var sql = "DELETE FROM tblModulo WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Modulo> Get(long idempresa, long idmodulo)
        {
            var sql = "SELECT IdEmpTask<Modulo> Get(long idempresa, long idmodulo)resa, IdModulo, IdCodigoModulo, IdModuloPadre, IdTipoElemento, Nombre, Accion, Controller, Titulo, Descripcion, imageRoot, Activo, Negocios, Tecnologia FROM tblModulo  WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Modulo>(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo });
                Modulo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Modulo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Modulo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdModulo, IdCodigoModulo, IdModuloPadre, IdTipoElemento, Nombre, Accion, Controller, Titulo, Descripcion, imageRoot, Activo, Negocios, Tecnologia FROM tblModulo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Modulo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Modulo entity)
        {
            var sql = "UPDATE tblModulo SET IdEmpresa = @idempresa, IdModulo = @idmodulo, IdCodigoModulo = @idcodigomodulo, IdModuloPadre = @idmodulopadre, IdTipoElemento = @idtipoelemento, Nombre = @nombre, Accion = @accion, Controller = @controller, Titulo = @titulo, Descripcion = @descripcion, imageRoot = @imageroot, Activo = @activo, Negocios = @negocios, Tecnologia = @tecnologia WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdModulo = entity.IdModulo });
                return _affectedRows;
            }
        }
    }
}
