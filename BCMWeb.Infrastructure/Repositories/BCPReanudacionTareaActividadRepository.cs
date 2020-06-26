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
    public class BCPReanudacionTareaActividadRepository : IBCPReanudacionTareaActividadRepository
    {
        private readonly IConfiguration _configuration;

        public BCPReanudacionTareaActividadRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BCPReanudacionTareaActividad entity)
        {
            var sql = "INSERT INTO tblBCPReanudacionTareaActividad (IdEmpresa, IdDocumentoBCP, IdBCPReanudacionTarea, , Descripcion, Procesado) VALUES(@IdEmpresa, @IdDocumentoBCP, @IdBCPReanudacionTarea, , @Descripcion, @Procesado);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea, long idbcpreanudaciontareaactividad)
        {
            var sql = "DELETE FROM tblBCPReanudacionTareaActividad WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPReanudacionTarea = @idbcpreanudaciontarea AND IdBCPReanudacionTareaActividad = @idbcpreanudaciontareaactividad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPReanudacionTarea = idbcpreanudaciontarea, IdBCPReanudacionTareaActividad = idbcpreanudaciontareaactividad });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BCPReanudacionTareaActividad> Get(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea, long idbcpreanudaciontareaactividad)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPReanudacionTarea, IdBCPReanudacionTareaActividad, Descripcion, Procesado FROM tblBCPReanudacionTareaActividad  WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPReanudacionTarea = @idbcpreanudaciontarea AND IdBCPReanudacionTareaActividad = @idbcpreanudaciontareaactividad;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPReanudacionTareaActividad>(sql, new { IdEmpresa = idempresa, IdDocumentoBCP = iddocumentobcp, IdBCPReanudacionTarea = idbcpreanudaciontarea, IdBCPReanudacionTareaActividad = idbcpreanudaciontareaactividad });
                BCPReanudacionTareaActividad _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BCPReanudacionTareaActividad> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BCPReanudacionTareaActividad>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBCP, IdBCPReanudacionTarea, IdBCPReanudacionTareaActividad, Descripcion, Procesado FROM tblBCPReanudacionTareaActividad ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BCPReanudacionTareaActividad>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BCPReanudacionTareaActividad entity)
        {
            var sql = "UPDATE tblBCPReanudacionTareaActividad SET IdEmpresa = @idempresa, IdDocumentoBCP = @iddocumentobcp, IdBCPReanudacionTarea = @idbcpreanudaciontarea, , Descripcion = @descripcion, Procesado = @procesado WHERE IdEmpresa = @idempresa AND IdDocumentoBCP = @iddocumentobcp AND IdBCPReanudacionTarea = @idbcpreanudaciontarea AND IdBCPReanudacionTareaActividad = @idbcpreanudaciontareaactividad;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBCP = entity.IdDocumentoBCP, IdBCPReanudacionTarea = entity.IdBCPReanudacionTarea, IdBCPReanudacionTareaActividad = entity.IdBCPReanudacionTareaActividad });
                return _affectedRows;
            }
        }
    }
}
