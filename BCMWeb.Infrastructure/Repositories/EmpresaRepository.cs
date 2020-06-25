using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly IConfiguration _configuration;

        public EmpresaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Empresa entity)
        {
            var sql = @"INSERT INTO tblEmpresa (NombreFiscal, RegistroFiscal, NombreComercial, DireccionAdministrativa, 
                                                      IdEstado, FechaUltimoEstado, LogoURL, FechaInicioActividad, CrearProcesos, 
                                                      CrearUnidadOrganizativa, CrearUnidadTrabajo, CrearAplicaciones, CrearDocumento, 
                                                      IdPais, IdPaisEstado, IdPaisEstadoCiudad)
                        VALUES(@NombreFiscal, @RegistroFiscal, @NombreComercial, @DireccionAdministrativa, @IdEstado, @FechaUltimoEstado, 
                        	   @LogoURL, @FechaInicioActividad, @CrearProcesos, @CrearUnidadOrganizativa, @CrearUnidadTrabajo, 
                        	   @CrearAplicaciones, @CrearDocumento, @IdPais, @IdPaisEstado, @IdPaisEstadoCiudad);";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long id)
        {
            var sql = @"DELETE FROM tblEmpresa WHERE IdEmpresa = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return _affectedRows;
            }
        }
        public async Task<Empresa> Get(long id)
        {
            var sql = @"SELECT IdEmpresa, NombreFiscal, RegistroFiscal, NombreComercial, DireccionAdministrativa, IdEstado, 
                               FechaUltimoEstado, LogoURL, FechaInicioActividad, CrearProcesos, CrearUnidadOrganizativa, 
                               CrearUnidadTrabajo, CrearAplicaciones, CrearDocumento, IdPais, IdPaisEstado, IdPaisEstadoCiudad
                        FROM tblEmpresa
                        WHERE IdEmpresa = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Empresa>(sql, new { Id = id });
                return _result.FirstOrDefault();
            }
        }
        public async Task<IEnumerable<Empresa>> GetAll()
        {
            var sql = @"SELECT IdEmpresa, NombreFiscal, RegistroFiscal, NombreComercial, DireccionAdministrativa, IdEstado, 
                               FechaUltimoEstado, LogoURL, FechaInicioActividad, CrearProcesos, CrearUnidadOrganizativa, 
                               CrearUnidadTrabajo, CrearAplicaciones, CrearDocumento, IdPais, IdPaisEstado, IdPaisEstadoCiudad
                        FROM tblEmpresa;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Empresa>(sql);
                return _result;
            }
        }
        public async Task<IEnumerable<Empresa>> EmpresasByUsuario(long idUsuario)
        {
            var sql = @"SELECT IdEmpresa, NombreFiscal, RegistroFiscal, NombreComercial, DireccionAdministrativa, IdEstado, 
                               FechaUltimoEstado, LogoURL, FechaInicioActividad, CrearProcesos, CrearUnidadOrganizativa, 
                               CrearUnidadTrabajo, CrearAplicaciones, CrearDocumento, IdPais, IdPaisEstado, IdPaisEstadoCiudad
                        FROM tblEmpresa emp
                        INNER JOIN tblEmpresaUsuario empUsr ON empUser.IdEmpresa = emp.IdEmpresa
                        WHERE empUser.IdUsuario = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Empresa>(sql, new { Id = idUsuario });
                return _result;
            }
        }
        public async Task<long> Update(Empresa entity)
        {

            var sql = @"UPDATE tblUsuario SET ClaveUsuario = @Passw, Nombre = @Nombre, Email = @Email WHERE IdUsuario = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { Id = entity.IdUsuario });
                return _affectedRows;
            }
        }
    }
}
