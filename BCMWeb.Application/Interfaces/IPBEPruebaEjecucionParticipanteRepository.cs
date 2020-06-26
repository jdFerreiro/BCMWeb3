using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionParticipanteRepository : IGenericRepository<PBEPruebaEjecucionParticipante>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idparticipante);
        Task<PBEPruebaEjecucionParticipante> Get(long idempresa, long idplanificacion, long idparticipante);
    }
}
