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
    public class FormatosEmailRepository : IFormatosEmailRepository
    {
        private readonly IConfiguration _configuration;

        public FormatosEmailRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(FormatosEmail entity)
        {
            var sql = "INSERT INTO tblFormatosEmail (IdEmpresa, IdCodigoModulo, IdCorreo, Descripcion, Subject, EmailBody) VALUES(@IdEmpresa, @IdCodigoModulo, @IdCorreo, @Descripcion, @Subject, @EmailBody);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idcodigomodulo, int idcorreo)
        {
            var sql = "DELETE FROM tblFormatosEmail WHERE IdEmpresa = @idempresa AND IdCodigoModulo = @idcodigomodulo AND IdCorreo = @idcorreo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdCodigoModulo = idcodigomodulo, IdCorreo = idcorreo });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<FormatosEmail> Get(long idempresa, long idcodigomodulo, int idcorreo)
        {
            var sql = "SELECT IdEmpresa, IdCodigoModulo, IdCorreo, Descripcion, Subject, EmailBody FROM tblFormatosEmail  WHERE IdEmpresa = @idempresa AND IdCodigoModulo = @idcodigomodulo AND IdCorreo = @idcorreo;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<FormatosEmail>(sql, new { IdEmpresa = idempresa, IdCodigoModulo = idcodigomodulo, IdCorreo = idcorreo });
                FormatosEmail _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<FormatosEmail> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<FormatosEmail>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdCodigoModulo, IdCorreo, Descripcion, Subject, EmailBody FROM tblFormatosEmail ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<FormatosEmail>(sql);
                return _result;
            }

        }
        public async Task<long> Update(FormatosEmail entity)
        {
            var sql = "UPDATE tblFormatosEmail SET IdEmpresa = @idempresa, IdCodigoModulo = @idcodigomodulo, IdCorreo = @idcorreo, Descripcion = @descripcion, Subject = @subject, EmailBody = @emailbody WHERE IdEmpresa = @idempresa AND IdCodigoModulo = @idcodigomodulo AND IdCorreo = @idcorreo;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdCodigoModulo = entity.IdCodigoModulo, IdCorreo = entity.IdCorreo });
                return _affectedRows;
            }
        }
    }
}
