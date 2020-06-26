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
    public class BIAComentarioRepository : IBIAComentarioRepository
    {
        private readonly IConfiguration _configuration;

        public BIAComentarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(BIAComentario entity)
        {
            var sql = "INSERT INTO tblBIAComentario (IdEmpresa, IdDocumentoBia, , Descripcion) VALUES(@IdEmpresa, @IdDocumentoBia, , @Descripcion);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long iddocumentobia, long idcomentario)
        {
            var sql = "DELETE FROM tblBIAComentario WHERE IdEmpresa = @idempresa AND IdDocumentoBia = @iddocumentobia AND IdComentario = @idcomentario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdDocumentoBia = iddocumentobia, IdComentario = idcomentario });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BIAComentario> Get(long idempresa, long iddocumentobia, long idcomentario)
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBia, IdComentario, Descripcion FROM tblBIAComentario  WHERE IdEmpresa = @idempresa AND IdDocumentoBia = @iddocumentobia AND IdComentario = @idcomentario;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAComentario>(sql, new { IdEmpresa = idempresa, IdDocumentoBia = iddocumentobia, IdComentario = idcomentario });
                BIAComentario _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<BIAComentario> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<BIAComentario>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdDocumentoBia, IdComentario, Descripcion FROM tblBIAComentario ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<BIAComentario>(sql);
                return _result;
            }

        }
        public async Task<long> Update(BIAComentario entity)
        {
            var sql = "UPDATE tblBIAComentario SET IdEmpresa = @idempresa, IdDocumentoBia = @iddocumentobia, , Descripcion = @descripcion WHERE IdEmpresa = @idempresa AND IdDocumentoBia = @iddocumentobia AND IdComentario = @idcomentario;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdDocumentoBia = entity.IdDocumentoBia, IdComentario = entity.IdComentario });
                return _affectedRows;
            }
        }
    }
}
