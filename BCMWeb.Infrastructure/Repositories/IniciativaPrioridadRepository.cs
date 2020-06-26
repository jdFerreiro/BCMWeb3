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
    public class IniciativaPrioridadRepository : IIniciativaPrioridadRepository
    {
        private readonly IConfiguration _configuration;

        public IniciativaPrioridadRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(IniciativaPrioridad entity)
        {
            var sql = "INSERT INTO tblIniciativaPrioridad (IdEmpresa, IdPrioridad, Nombre) VALUES(@IdEmpresa, @IdPrioridad, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, short idprioridad)
        {
            var sql = "DELETE FROM tblIniciativaPrioridad WHERE IdEmpresa = @idempresa AND IdPrioridad = @idprioridad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdPrioridad = idprioridad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IniciativaPrioridad> Get(long idempresa, short idprioridad)
        {
            var sql = "SELECT IdEmpresa, IdPrioridad, Nombre FROM tblIniciativaPrioridad  WHERE IdEmpresa = @idempresa AND IdPrioridad = @idprioridad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<IniciativaPrioridad>(sql, new { IdEmpresa = idempresa, IdPrioridad = idprioridad });
                IniciativaPrioridad _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<IniciativaPrioridad> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<IniciativaPrioridad>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdPrioridad, Nombre FROM tblIniciativaPrioridad ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<IniciativaPrioridad>(sql);
                return _result;
            }

        }
        public async Task<long> Update(IniciativaPrioridad entity)
        {
            var sql = "UPDATE tblIniciativaPrioridad SET IdEmpresa = @idempresa, IdPrioridad = @idprioridad, Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdPrioridad = @idprioridad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdPrioridad = entity.IdPrioridad });
                return _affectedRows;
            }
        }
    }
}
