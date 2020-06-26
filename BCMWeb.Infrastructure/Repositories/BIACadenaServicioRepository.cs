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
    public class BIACadenaServicioRepository : IBIACadenaServicioRepository
    {
        private readonly IConfiguration _configuration;

        public BIACadenaServicioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIACadenaServicio entity)
        {
            var sql = "INSERT INTO tblBIACadenaServicio (IdEmpresa, IdCadenaServicio, Descripcion) VALUES(@IdEmpresa, @IdCadenaServicio, @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idcadenaservicio)
        {
            var sql = "DELETE FROM tblBIACadenaServicio WHERE IdEmpresa = @idempresa AND IdCadenaServicio = @idcadenaservicio;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdCadenaServicio = idcadenaservicio });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIACadenaServicio> Get(long idempresa, long idcadenaservicio)
        {
            var sql = "SELECT IdEmpresa, IdCadenaServicio, Descripcion FROM tblBIACadenaServicio  WHERE IdEmpresa = @idempresa AND IdCadenaServicio = @idcadenaservicio;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIACadenaServicio>(sql, new { IdEmpresa = idempresa, IdCadenaServicio = idcadenaservicio });
                BIACadenaServicio _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIACadenaServicio> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIACadenaServicio>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdCadenaServicio, Descripcion FROM tblBIACadenaServicio ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIACadenaServicio>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIACadenaServicio entity)
        {
            var sql = "UPDATE tblBIACadenaServicio SET IdEmpresa = @idempresa, IdCadenaServicio = @idcadenaservicio, Descripcion = @descripcion WHERE IdEmpresa = @idempresa AND IdCadenaServicio = @idcadenaservicio;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdCadenaServicio = entity.IdCadenaServicio });
                return _affectedRows;
            }
        }
    }
}
