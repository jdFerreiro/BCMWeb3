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
    public class CargoRepository : ICargoRepository
    {
        private readonly IConfiguration _configuration;

        public CargoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Cargo entity)
        {
            var sql = "INSERT INTO tblCargo (IdEmpresa, , Descripcion) VALUES(@IdEmpresa, , @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idcargo)
        {
            var sql = "DELETE FROM tblCargo WHERE IdEmpresa = @idempresa AND IdCargo = @idcargo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdCargo = idcargo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Cargo> Get(long idempresa, long idcargo)
        {
            var sql = "SELECT IdEmpresa, IdCargo, Descripcion FROM tblCargo  WHERE IdEmpresa = @idempresa AND IdCargo = @idcargo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cargo>(sql, new { IdEmpresa = idempresa, IdCargo = idcargo });
                Cargo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Cargo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Cargo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdCargo, Descripcion FROM tblCargo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Cargo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Cargo entity)
        {
            var sql = "UPDATE tblCargo SET IdEmpresa = @idempresa, , Descripcion = @descripcion WHERE IdEmpresa = @idempresa AND IdCargo = @idcargo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdCargo = entity.IdCargo });
                return _affectedRows;
            }
        }
    }
}
