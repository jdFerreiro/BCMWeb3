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
    public class VicepresidenciaRepository : IVicepresidenciaRepository
    {
        private readonly IConfiguration _configuration;

        public VicepresidenciaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(VicePresidency entity)
        {
            var sql = "INSERT INTO tblVicepresidencia (CompanyId, , Name, AvenueStreetName, BuildingHouseName, FloorLevel, TowerSideName, UrbanizationName, CityId, CountryStateId, CountryId) VALUES(@CompanyId, , @Name, @AvenueStreetName, @BuildingHouseName, @FloorLevel, @TowerSideName, @UrbanizationName, @CityId, @CountryStateId, @CountryId);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idvicepresidencia)
        {
            var sql = "DELETE FROM tblVicepresidencia WHERE CompanyId = @idempresa AND VicepresidencyId = @idvicepresidencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdVicepresidencia = idvicepresidencia });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<VicePresidency> Get(long idempresa, long idvicepresidencia)
        {
            var sql = "SELECT CompanyId, VicepresidencyId, Name, AvenueStreetName, BuildingHouseName, FloorLevel, TowerSideName, UrbanizationName, CityId, CountryStateId, CountryId FROM tblVicepresidencia  WHERE CompanyId = @idempresa AND VicepresidencyId = @idvicepresidencia;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<VicePresidency>(sql, new { IdEmpresa = idempresa, IdVicepresidencia = idvicepresidencia });
                VicePresidency _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<VicePresidency> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<VicePresidency>> GetAll()
        {
            var sql = "SELECT CompanyId, VicepresidencyId, Name, AvenueStreetName, BuildingHouseName, FloorLevel, TowerSideName, UrbanizationName, CityId, CountryStateId, CountryId FROM tblVicepresidencia ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<VicePresidency>(sql);
                return _result;
            }

        }
        public async Task<long> Update(VicePresidency entity)
        {
            var sql = "UPDATE tblVicepresidencia SET CompanyId = @idempresa, , Name = @nombre, AvenueStreetName = @calleavenida, BuildingHouseName = @edificiocasa, FloorLevel = @pisonivel, TowerSideName = @torreala, UrbanizationName = @urbanizacion, CityId = @idciudad, CountryStateId = @idestado, CountryId = @idpais WHERE CompanyId = @idempresa AND VicepresidencyId = @idvicepresidencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { entity.CompanyId, entity.VicepresidencyId });
                return _affectedRows;
            }
        }
    }
}
