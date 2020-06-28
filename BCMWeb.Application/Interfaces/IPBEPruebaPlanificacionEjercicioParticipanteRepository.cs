using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionEjercicioParticipanteRepository : IGenericRepository<PPETestScheduleExerciseParticipant>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
        Task<PPETestScheduleExerciseParticipant> Get(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
    }
}
