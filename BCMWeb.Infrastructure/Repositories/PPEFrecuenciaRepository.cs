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
    public class PPEFrecuenciaRepository : IPPEFrecuenciaRepository
    {
        private readonly IConfiguration _configuration;

        public PPEFrecuenciaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(PPEFrecuencia entity)
        {
            var sql = "INSERT INTO tblPPEFrecuencia (IdEmpresa, IdDocumento, IdTipoDocumento, , TipoPrueba, Participantes, Proposito, IdTipoFrecuencia) VALUES(@IdEmpresa, @IdDocumento, @IdTipoDocumento, , @TipoPrueba, @Participantes, @Proposito, @IdTipoFrecuencia);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idppefrecuencia)
        {
            var sql = "DELETE FROM tblPPEFrecuencia WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdPPEFrecuencia = @idppefrecuencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdPPEFrecuencia = idppefrecuencia });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PPEFrecuencia> Get(long idempresa, long iddocumento, long idtipodocumento, long idppefrecuencia)
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdPPEFrecuencia, TipoPrueba, Participantes, Proposito, IdTipoFrecuencia FROM tblPPEFrecuencia  WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdPPEFrecuencia = @idppefrecuencia;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PPEFrecuencia>(sql, new { IdEmpresa = idempresa, IdDocumento = iddocumento, IdTipoDocumento = idtipodocumento, IdPPEFrecuencia = idppefrecuencia });
                PPEFrecuencia _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<PPEFrecuencia> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<PPEFrecuencia>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumento, IdTipoDocumento, IdPPEFrecuencia, TipoPrueba, Participantes, Proposito, IdTipoFrecuencia FROM tblPPEFrecuencia ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<PPEFrecuencia>(sql);
                return _result;
            }

        }
        public async Task<long> Update(PPEFrecuencia entity)
        {
            var sql = "UPDATE tblPPEFrecuencia SET IdEmpresa = @idempresa, IdDocumento = @iddocumento, IdTipoDocumento = @idtipodocumento, , TipoPrueba = @tipoprueba, Participantes = @participantes, Proposito = @proposito, IdTipoFrecuencia = @idtipofrecuencia WHERE IdEmpresa = @idempresa AND IdDocumento = @iddocumento AND IdTipoDocumento = @idtipodocumento AND IdPPEFrecuencia = @idppefrecuencia;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumento = entity.IdDocumento, IdTipoDocumento = entity.IdTipoDocumento, IdPPEFrecuencia = entity.IdPPEFrecuencia });
                return _affectedRows;
            }
        }
    }
}
