using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionEjercicioRecursoRepository : IGenericRepository<TblPbepruebaPlanificacionEjercicioRecurso>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idrecurso);
        Task<TblPbepruebaPlanificacionEjercicioRecurso> Get(long idempresa, long idplanificacion, long idejercicio, long idrecurso);
    }
}
