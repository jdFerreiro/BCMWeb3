using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionEjercicioParticipanteRepository : IGenericRepository<PBEPruebaEjecucionEjercicioParticipante>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
        Task<PBEPruebaEjecucionEjercicioParticipante> Get(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
    }
}
