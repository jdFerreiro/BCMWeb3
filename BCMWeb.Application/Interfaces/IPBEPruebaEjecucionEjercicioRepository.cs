using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionEjercicioRepository : IGenericRepository<PPETestExecutionExercise>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio);
        Task<PPETestExecutionExercise> Get(long idempresa, long idplanificacion, long idejercicio);
    }
}
