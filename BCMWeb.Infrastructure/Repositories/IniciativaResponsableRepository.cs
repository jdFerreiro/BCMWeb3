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
    public class IniciativaResponsableRepository : IIniciativaResponsableRepository
    {
        private readonly IConfiguration _configuration;

        public IniciativaResponsableRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(IniciativaResponsable entity)
        {
            var sql = "INSERT INTO tblIniciativaResponsable (IdEmpresa, , Nombre) VALUES(@IdEmpresa, , @Nombre);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idresponsable)
        {
            var sql = "DELETE FROM tblIniciativaResponsable WHERE IdEmpresa = @idempresa AND IdResponsable = @idresponsable;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdResponsable = idresponsable });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IniciativaResponsable> Get(long idempresa, long idresponsable)
        {
            var sql = "SELECT IdEmpresa, IdResponsable, Nombre FROM tblIniciativaResponsable  WHERE IdEmpresa = @idempresa AND IdResponsable = @idresponsable;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<IniciativaResponsable>(sql, new { IdEmpresa = idempresa, IdResponsable = idresponsable });
                IniciativaResponsable _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<IniciativaResponsable> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<IniciativaResponsable>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdResponsable, Nombre FROM tblIniciativaResponsable ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<IniciativaResponsable>(sql);
                return _result;
            }

        }
        public async Task<long> Update(IniciativaResponsable entity)
        {
            var sql = "UPDATE tblIniciativaResponsable SET IdEmpresa = @idempresa, , Nombre = @nombre WHERE IdEmpresa = @idempresa AND IdResponsable = @idresponsable;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdResponsable = entity.IdResponsable });
                return _affectedRows;
            }
        }
    }
}
