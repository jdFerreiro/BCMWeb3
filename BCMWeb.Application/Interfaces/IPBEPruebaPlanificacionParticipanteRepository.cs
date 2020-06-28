using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionParticipanteRepository : IGenericRepository<PPETestScheduleParticipant>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idparticipante);
        Task<PPETestScheduleParticipant> Get(long idempresa, long idplanificacion, long idparticipante);
    }
}
