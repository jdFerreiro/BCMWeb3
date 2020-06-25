using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly IConfiguration _configuration;

        public PersonaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Persona entity)
        {
            var sql = @"INSERT INTO tblPersona(IdEmpresa, Nombre, Identificacion, IdUnidadOrganizativa, IdCargo, IdUsuario)
                        VALUES(@IdEmpresa, @Nombre, @Identificacion, @IdUnidadOrganizativa, @IdCargo, @IdUsuario);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long id)
        {
            var sql = @"DELETE FROM tblPersona WHERE  IdPersona = @IdPersona;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return _affectedRows;
            }
        }
        public async Task<Persona> Get(long id)
        {
            var sql = @"SELECT IdEmpresa, IdPersona, Nombre, Identificacion, IdUnidadOrganizativa, IdCargo, IdUsuario
                        FROM tblPersona WHERE IdPersona = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Persona>(sql, new { Id = id });
                Persona _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }
        public async Task<IEnumerable<Persona>> GetAll()
        {
            var sql = @"SELECT IdEmpresa, IdPersona, Nombre, Identificacion, IdUnidadOrganizativa, IdCargo, IdUsuario
                        FROM tblPersona;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Persona>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Persona entity)
        {
            var sql = @"UPDATE tblPersona SET IdEmpresa =  @IdEmpresa, Nombre =  @Nombre, Identificacion =  @Identificacion, 
                                              IdUnidadOrganizativa =  @IdUnidadOrganizativa, IdCargo =  @IdCargo, 
                                              IdUsuario =  @IdUsuario
                        WHERE  IdPersona = @IdPersona;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = entity.IdPersona });
                return _affectedRows;
            }
        }
    }
}
