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
    public class IniciativasRepository : IIniciativasRepository
    {
        private readonly IConfiguration _configuration;

        public IniciativasRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<long> Add(Iniciativas entity)
        {
            var sql = "INSERT INTO tblIniciativas (IdEmpresa, , NroIniciativa, Nombre, Descripcion, IdUnidadOrganizativa, UnidadOrganizativa, NombreResponsable, FechaInicioEstimada, FechaInicioReal, FechaCierreEstimada, FechaCierreReal, PresupuestoEstimado, PresupuestoReal, IdEstatusIniciativa, Observacion, IdPrioridad, MontoAbonado, MontoPendiente, PorcentajeAvance, HorasEstimadas, HorasConsumidas) VALUES(@IdEmpresa, , @NroIniciativa, @Nombre, @Descripcion, @IdUnidadOrganizativa, @UnidadOrganizativa, @NombreResponsable, @FechaInicioEstimada, @FechaInicioReal, @FechaCierreEstimada, @FechaCierreReal, @PresupuestoEstimado, @PresupuestoReal, @IdEstatusIniciativa, @Observacion, @IdPrioridad, @MontoAbonado, @MontoPendiente, @PorcentajeAvance, @HorasEstimadas, @HorasConsumidas);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, entity);
                return _affectedRows;
            }
        }
        public async Task<long> Delete(long idempresa, long idiniciativa)
        {
            var sql = "DELETE FROM tblIniciativas WHERE IdEmpresa = @idempresa AND IdIniciativa = @idiniciativa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = idempresa, IdIniciativa = idiniciativa });
                return _affectedRows;
            }
        }

        public Task<long> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Iniciativas> Get(long idempresa, long idiniciativa)
        {
            var sql = "SELECT IdEmpresa, IdIniciativa, NroIniciativa, Nombre, Descripcion, IdUnidadOrganizativa, UnidadOrganizativa, NombreResponsable, FechaInicioEstimada, FechaInicioReal, FechaCierreEstimada, FechaCierreReal, PresupuestoEstimado, PresupuestoReal, IdEstatusIniciativa, Observacion, IdPrioridad, MontoAbonado, MontoPendiente, PorcentajeAvance, HorasEstimadas, HorasConsumidas FROM tblIniciativas  WHERE IdEmpresa = @idempresa AND IdIniciativa = @idiniciativa;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Iniciativas>(sql, new { IdEmpresa = idempresa, IdIniciativa = idiniciativa });
                Iniciativas _Persona = _result.FirstOrDefault();
                return _Persona;
            }

        }

        public Task<Iniciativas> Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Iniciativas>> GetAll()
        {
            var sql = "SELECT IdEmpresa, IdIniciativa, NroIniciativa, Nombre, Descripcion, IdUnidadOrganizativa, UnidadOrganizativa, NombreResponsable, FechaInicioEstimada, FechaInicioReal, FechaCierreEstimada, FechaCierreReal, PresupuestoEstimado, PresupuestoReal, IdEstatusIniciativa, Observacion, IdPrioridad, MontoAbonado, MontoPendiente, PorcentajeAvance, HorasEstimadas, HorasConsumidas FROM tblIniciativas ;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _result = await connection.QueryAsync<Iniciativas>(sql);
                return _result;
            }

        }
        public async Task<long> Update(Iniciativas entity)
        {
            var sql = "UPDATE tblIniciativas SET IdEmpresa = @idempresa, , NroIniciativa = @nroiniciativa, Nombre = @nombre, Descripcion = @descripcion, IdUnidadOrganizativa = @idunidadorganizativa, UnidadOrganizativa = @unidadorganizativa, NombreResponsable = @nombreresponsable, FechaInicioEstimada = @fechainicioestimada, FechaInicioReal = @fechainicioreal, FechaCierreEstimada = @fechacierreestimada, FechaCierreReal = @fechacierrereal, PresupuestoEstimado = @presupuestoestimado, PresupuestoReal = @presupuestoreal, IdEstatusIniciativa = @idestatusiniciativa, Observacion = @observacion, IdPrioridad = @idprioridad, MontoAbonado = @montoabonado, MontoPendiente = @montopendiente, PorcentajeAvance = @porcentajeavance, HorasEstimadas = @horasestimadas, HorasConsumidas = @horasconsumidas WHERE IdEmpresa = @idempresa AND IdIniciativa = @idiniciativa;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var _affectedRows = await connection.ExecuteAsync(sql, new { IdEmpresa = entity.IdEmpresa, IdIniciativa = entity.IdIniciativa });
                return _affectedRows;
            }
        }
    }
}
