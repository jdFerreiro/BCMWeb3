using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionEjercicioRecursoRepository : IGenericRepository<TblPbepruebaEjecucionEjercicioRecurso>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idrecurso);
        Task<TblPbepruebaEjecucionEjercicioRecurso> Get(long idempresa, long idplanificacion, long idejercicio, long idrecurso);
    }
}
