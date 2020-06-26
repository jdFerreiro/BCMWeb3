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
    public class Dispositivo1Repository: IDispositivo1Repository
    {
        private readonly IConfiguration _configuration;

        public Dispositivo1Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Dispositivo1 entity)
        {
            var sql = "INSERT INTO tblDispositivo1 (IdUsuario, FechaRegistro, IMEI_Dispositivo, NombreDispositivo, Fabricante, Modelo, Plataforma, Version, TipoDispositivo, TokenDispositivo) VALUES(@IdUsuario, @FechaRegistro, @IMEI_Dispositivo, @NombreDispositivo, @Fabricante, @Modelo, @Plataforma, @Version, @TipoDispositivo, @TokenDispositivo);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long iddispositivo)
        {
            var sql = "DELETE FROM tblDispositivo1 WHERE IdDispositivo = @iddispositivo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = iddispositivo });
                return _affectedRows;
            }
        }
        public async Task<Dispositivo1> Get(long iddispositivo)
        {
            var sql = "SELECT IdDispositivo, IdUsuario, FechaRegistro, IMEI_Dispositivo, NombreDispositivo, Fabricante, Modelo, Plataforma, Version, TipoDispositivo, TokenDispositivo FROM tblDispositivo1  WHERE IdDispositivo = @iddispositivo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Dispositivo1>(sql, new { IdDispositivo = iddispositivo });
                Dispositivo1 _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<Dispositivo1>> GetAll()
        {
            var sql = "SELECT IdDispositivo, IdUsuario, FechaRegistro, IMEI_Dispositivo, NombreDispositivo, Fabricante, Modelo, Plataforma, Version, TipoDispositivo, TokenDispositivo FROM tblDispositivo1 ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Dispositivo1>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Dispositivo1 entity)
        {
            var sql = "UPDATE tblDispositivo1 SET IdUsuario = @idusuario, FechaRegistro = @fecharegistro, IMEI_Dispositivo = @imei_dispositivo, NombreDispositivo = @nombredispositivo, Fabricante = @fabricante, Modelo = @modelo, Plataforma = @plataforma, Version = @version, TipoDispositivo = @tipodispositivo, TokenDispositivo = @tokendispositivo WHERE IdDispositivo = @iddispositivo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdDispositivo = entity.IdDispositivo });
                return _affectedRows;
            }
        }
    }
}
