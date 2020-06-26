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
    public class ImpactoRiesgoRepository : IImpactoRiesgoRepository
    {
        private readonly IConfiguration _configuration;

        public ImpactoRiesgoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(ImpactoRiesgo entity)
        {
            var sql = "INSERT INTO tblImpactoRiesgo (IdEmpresa, IdImpacto, Nombre) VALUES(@IdEmpresa, @IdImpacto, @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, short idimpacto)
        {
            var sql = "DELETE FROM tblImpactoRiesgo WHERE IdEmpresa = @idempresa AND IdImpacto = @idimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdImpacto = idimpacto });
                return _affectedRows;
            }
        }
        public Task<long> Delete(long id)
        {
            throw new NotImplementedException();
        }
        public async Task<ImpactoRiesgo> Get(long idempresa, short idimpacto)
        {
            var sql = "SELECT IdEmpresa, IdImpacto, Nombre FROM tblImpactoRiesgo  WHERE IdEmpresa = @idempresa AND IdImpacto = @idimpacto;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<ImpactoRiesgo>(sql, new { IdEmpresa = idempresa, IdImpacto = idimpacto });
                ImpactoRiesgo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public Task<ImpactoRiesgo> Get(long id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<ImpactoRiesgo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdImpacto, Nombre FROM tblImpactoRiesgo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<ImpactoRiesgo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(ImpactoRiesgo entity)
        {
            var sql = "UPDATE tblImpactoRiesgo SET IdEmpresa = @idempresa, IdImpacto = @idimpacto, Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdImpacto = @idimpacto;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdImpacto = entity.IdImpacto });
                return _affectedRows;
            }
        }
    }
}
