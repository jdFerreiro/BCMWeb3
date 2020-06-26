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
    public class EscalaRepository : IEscalaRepository
    {
        private readonly IConfiguration _configuration;

        public EscalaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Escala entity)
        {
            var sql = "INSERT INTO tblEscala (IdEmpresa, IdEscala, IdTipoEscala, Valor, Descripcion, FechaRegistro, PosicionEscala) VALUES(@IdEmpresa, @IdEscala, @IdTipoEscala, @Valor, @Descripcion, @FechaRegistro, @PosicionEscala);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idescala)
        {
            var sql = "DELETE FROM tblEscala WHERE IdEmpresa = @idempresa AND IdEscala = @idescala;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdEscala = idescala });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Escala> Get(long idempresa, long idescala)
        {
            var sql = "SELECT IdEmpresa, IdEscala, IdTipoEscala, Valor, Descripcion, FechaRegistro, PosicionEscala FROM tblEscala  WHERE IdEmpresa = @idempresa AND IdEscala = @idescala;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Escala>(sql, new { IdEmpresa = idempresa, IdEscala = idescala });
                Escala _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Escala> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Escala>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdEscala, IdTipoEscala, Valor, Descripcion, FechaRegistro, PosicionEscala FROM tblEscala ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Escala>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Escala entity)
        {
            var sql = "UPDATE tblEscala SET IdEmpresa = @idempresa, IdEscala = @idescala, IdTipoEscala = @idtipoescala, Valor = @valor, Descripcion = @descripcion, FechaRegistro = @fecharegistro, PosicionEscala = @posicionescala WHERE IdEmpresa = @idempresa AND IdEscala = @idescala;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdEscala = entity.IdEscala });
                return _affectedRows;
            }
        }
    }
}
