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
    public class Iniciativas_AnexoRepository : IIniciativas_AnexoRepository
    {
        private readonly IConfiguration _configuration;

        public Iniciativas_AnexoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Iniciativas_Anexo entity)
        {
            var sql = "INSERT INTO tblIniciativas_Anexo (IdEmpresa, IdIniciativa, , Nombre, RutaArchivo, fechaRegistro) VALUES(@IdEmpresa, @IdIniciativa, , @Nombre, @RutaArchivo, @fechaRegistro);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idiniciativa, long idanexo)
        {
            var sql = "DELETE FROM tblIniciativas_Anexo WHERE IdEmpresa = @idempresa AND IdIniciativa = @idiniciativa AND IdAnexo = @idanexo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdIniciativa = idiniciativa, IdAnexo = idanexo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Iniciativas_Anexo> Get(long idempresa, long idiniciativa, long idanexo)
        {
            var sql = "SELECT IdEmpresa, IdIniciativa, IdAnexo, Nombre, RutaArchivo, fechaRegistro FROM tblIniciativas_Anexo  WHERE IdEmpresa = @idempresa AND IdIniciativa = @idiniciativa AND IdAnexo = @idanexo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Iniciativas_Anexo>(sql, new { IdEmpresa = idempresa, IdIniciativa = idiniciativa, IdAnexo = idanexo });
                Iniciativas_Anexo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Iniciativas_Anexo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Iniciativas_Anexo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdIniciativa, IdAnexo, Nombre, RutaArchivo, fechaRegistro FROM tblIniciativas_Anexo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Iniciativas_Anexo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Iniciativas_Anexo entity)
        {
            var sql = "UPDATE tblIniciativas_Anexo SET IdEmpresa = @idempresa, IdIniciativa = @idiniciativa, , Nombre = @nombre, RutaArchivo = @rutaarchivo, fechaRegistro = @fecharegistro WHERE IdEmpresa = @idempresa AND IdIniciativa = @idiniciativa AND IdAnexo = @idanexo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdIniciativa = entity.IdIniciativa, IdAnexo = entity.IdAnexo });
                return _affectedRows;
            }
        }
    }
}
