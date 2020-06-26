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
    public class ProbabilidadRiesgoRepository : IProbabilidadRiesgoRepository
    {
        private readonly IConfiguration _configuration;

        public ProbabilidadRiesgoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(ProbabilidadRiesgo entity)
        {
            var sql = "INSERT INTO tblProbabilidadRiesgo (IdEmpresa, IdProbabilidad, Nombre, EtiquetaGrafico) VALUES(@IdEmpresa, @IdProbabilidad, @Nombre, @EtiquetaGrafico);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, short idprobabilidad)
        {
            var sql = "DELETE FROM tblProbabilidadRiesgo WHERE IdEmpresa = @idempresa AND IdProbabilidad = @idprobabilidad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdProbabilidad = idprobabilidad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ProbabilidadRiesgo> Get(long idempresa, short idprobabilidad)
        {
            var sql = "SELECT IdEmpresa, IdProbabilidad, Nombre, EtiquetaGrafico FROM tblProbabilidadRiesgo  WHERE IdEmpresa = @idempresa AND IdProbabilidad = @idprobabilidad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<ProbabilidadRiesgo>(sql, new { IdEmpresa = idempresa, IdProbabilidad = idprobabilidad });
                ProbabilidadRiesgo _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<ProbabilidadRiesgo> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ProbabilidadRiesgo>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdProbabilidad, Nombre, EtiquetaGrafico FROM tblProbabilidadRiesgo ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<ProbabilidadRiesgo>(sql);
                return _result;
            }

        }
        public async Task<long> Update(ProbabilidadRiesgo entity)
        {
            var sql = "UPDATE tblProbabilidadRiesgo SET IdEmpresa = @idempresa, IdProbabilidad = @idprobabilidad, Nombre = @nombre, EtiquetaGrafico = @etiquetagrafico WHERE IdEmpresa = @idempresa AND IdProbabilidad = @idprobabilidad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdProbabilidad = entity.IdProbabilidad });
                return _affectedRows;
            }
        }

        Task<long> IProbabilidadRiesgoRepository.Delete(long idempresa, short idprobabilidad)
        {
            throw new System.NotImplementedException();
        }
    }
}
