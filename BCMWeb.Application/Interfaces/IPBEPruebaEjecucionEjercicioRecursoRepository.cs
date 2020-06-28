using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionEjercicioRecursoRepository : IGenericRepository<PPETestExecutionExerciseResource>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idrecurso);
        Task<PPETestExecutionExerciseResource> Get(long idempresa, long idplanificacion, long idejercicio, long idrecurso);
    }
}
