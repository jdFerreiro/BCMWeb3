using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionParticipanteRepository : IGenericRepository<PPETestExecutionParticipant>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idparticipante);
        Task<PPETestExecutionParticipant> Get(long idempresa, long idplanificacion, long idparticipante);
    }
}
