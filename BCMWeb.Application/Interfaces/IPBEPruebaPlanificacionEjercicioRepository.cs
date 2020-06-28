using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionEjercicioRepository : IGenericRepository<PPETestScheduleExercise>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio);
        Task<PPETestScheduleExercise> Get(long idempresa, long idplanificacion, long idejercicio);
    }
}
