using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoAccionRepository : IGenericRepository<TblPlanTrabajoAccion>
    {
        Task<long> Delete(long idempresa, long idplanaccion);
        Task<TblPlanTrabajoAccion> Get(long idempresa, long idplanaccion);
    }
}
