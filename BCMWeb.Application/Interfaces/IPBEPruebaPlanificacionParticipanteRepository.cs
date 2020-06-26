using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionParticipanteRepository : IGenericRepository<PBEPruebaPlanificacionParticipante>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idparticipante);
        Task<PBEPruebaPlanificacionParticipante> Get(long idempresa, long idplanificacion, long idparticipante);
    }
}
