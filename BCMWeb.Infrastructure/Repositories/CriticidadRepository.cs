using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class CriticidadRepository : ICriticidadRepository
    {
        private readonly IConfiguration _configuration;

        public CriticidadRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Criticidad entity)
        {
            var sql = "INSERT INTO tblCriticidad (FechaAplicacion, IdEmpresa, IdTipoEscala, DescripcionEscala) VALUES(@FechaAplicacion, @IdEmpresa, @IdTipoEscala, @DescripcionEscala);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(DateTime fechaaplicacion, long idempresa, long idtipoescala)
        {
            var sql = "DELETE FROM tblCriticidad WHERE FechaAplicacion = @fechaaplicacion AND IdEmpresa = @idempresa AND IdTipoEscala = @idtipoescala;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { FechaAplicacion = fechaaplicacion, IdEmpresa = idempresa, IdTipoEscala = idtipoescala });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Criticidad> Get(DateTime fechaaplicacion, long idempresa, long idtipoescala)
        {
            var sql = "SELECT FechaAplicacion, IdEmpresa, IdTipoEscala, DescripcionEscala FROM tblCriticidad  WHERE FechaAplicacion = @fechaaplicacion AND IdEmpresa = @idempresa AND IdTipoEscala = @idtipoescala;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Criticidad>(sql, new { FechaAplicacion = fechaaplicacion, IdEmpresa = idempresa, IdTipoEscala = idtipoescala });
                Criticidad _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Criticidad> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Criticidad>> GetAll()
        {
            var sql = "SELECT FechaAplicacion, IdEmpresa, IdTipoEscala, DescripcionEscala FROM tblCriticidad ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Criticidad>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Criticidad entity)
        {
            var sql = "UPDATE tblCriticidad SET FechaAplicacion = @fechaaplicacion, IdEmpresa = @idempresa, IdTipoEscala = @idtipoescala, DescripcionEscala = @descripcionescala WHERE FechaAplicacion = @fechaaplicacion AND IdEmpresa = @idempresa AND IdTipoEscala = @idtipoescala;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { FechaAplicacion = entity.FechaAplicacion, IdEmpresa = entity.IdEmpresa, IdTipoEscala = entity.IdTipoEscala });
                return _affectedRows;
            }
        }
    }
}
