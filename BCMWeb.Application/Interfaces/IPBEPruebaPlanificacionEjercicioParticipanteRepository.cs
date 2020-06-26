using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionEjercicioParticipanteRepository : IGenericRepository<PBEPruebaPlanificacionEjercicioParticipante>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
        Task<PBEPruebaPlanificacionEjercicioParticipante> Get(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
    }
}
