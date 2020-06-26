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
    public class ModuloAnexoRepository : IModuloAnexoRepository
    {
        private readonly IConfiguration _configuration;

        public ModuloAnexoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(ModuloAnexo entity)
        {
            var sql = "INSERT INTO tblModuloAnexo (IdEmpresa, IdModulo, Negocios, , ParentId, Nombre, IsFolder, Data, LastWriteTime) VALUES(@IdEmpresa, @IdModulo, @Negocios, , @ParentId, @Nombre, @IsFolder, @Data, @LastWriteTime);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idmodulo, bool negocios, long idanexo)
        {
            var sql = "DELETE FROM tblModuloAnexo WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND Negocios = @negocios AND IdAnexo = @idanexo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo, Negocios = negocios, IdAnexo = idanexo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ModuloAnexo> Get(long idempresa, long idmodulo, bool negocios, long idanexo)
        {
            var sql = "SELECT IdEmpresa, IdModulo, Negocios, IdAnexo, ParentId, Nombre, IsFolder, Data, LastWriteTime FROM tblModuloAnexo  WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND Negocios = @negocios AND IdAnexo = @idanexo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<ModuloAnexo>(sql, new { IdEmpresa = idempresa, IdModulo = idmodulo, Negocios = negocios, IdAnexo = idanexo });
                ModuloAnexo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<ModuloAnexo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ModuloAnexo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdModulo, Negocios, IdAnexo, ParentId, Nombre, IsFolder, Data, LastWriteTime FROM tblModuloAnexo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<ModuloAnexo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(ModuloAnexo entity)
        {
            var sql = "UPDATE tblModuloAnexo SET IdEmpresa = @idempresa, IdModulo = @idmodulo, Negocios = @negocios, , ParentId = @parentid, Nombre = @nombre, IsFolder = @isfolder, Data = @data, LastWriteTime = @lastwritetime WHERE IdEmpresa = @idempresa AND IdModulo = @idmodulo AND Negocios = @negocios AND IdAnexo = @idanexo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdModulo = entity.IdModulo, Negocios = entity.Negocios, IdAnexo = entity.IdAnexo });
                return _affectedRows;
            }
        }
    }
}
