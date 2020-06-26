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
    public class DispositivoRepository: IDispositivoRepository
    {
        private readonly IConfiguration _configuration;

        public DispositivoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Dispositivo entity)
        {
            var sql = "INSERT INTO tblDispositivo (fechaRegistro, IdUnicoDispositivo, nombre, fabricante, modelo, plataforma, version, tipo, token) VALUES(@fechaRegistro, @IdUnicoDispositivo, @nombre, @fabricante, @modelo, @plataforma, @version, @tipo, @token);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long iddispositivo)
        {
            var sql = "DELETE FROM tblDispositivo WHERE IdDispositivo = @iddispositivo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = iddispositivo });
                return _affectedRows;
            }
        }
        public async Task<Dispositivo> Get(long iddispositivo)
        {
            var sql = "SELECT IdDispositivo, fechaRegistro, IdUnicoDispositivo, nombre, fabricante, modelo, plataforma, version, tipo, token FROM tblDispositivo  WHERE IdDispositivo = @iddispositivo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Dispositivo>(sql, new { IdDispositivo = iddispositivo });
                Dispositivo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<Dispositivo>> GetAll()
        {
            var sql = "SELECT IdDispositivo, fechaRegistro, IdUnicoDispositivo, nombre, fabricante, modelo, plataforma, version, tipo, token FROM tblDispositivo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Dispositivo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Dispositivo entity)
        {
            var sql = "UPDATE tblDispositivo SET fechaRegistro = @fecharegistro, IdUnicoDispositivo = @idunicodispositivo, nombre = @nombre, fabricante = @fabricante, modelo = @modelo, plataforma = @plataforma, version = @version, tipo = @tipo, token = @token WHERE IdDispositivo = @iddispositivo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = entity.IdDispositivo });
                return _affectedRows;
            }
        }
    }
}
