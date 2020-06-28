using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionEjercicioParticipanteRepository : IGenericRepository<PPETestExecutionExerciseParticipant>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
        Task<PPETestExecutionExerciseParticipant> Get(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
    }
}
