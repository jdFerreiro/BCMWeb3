using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoAccionRepository : IGenericRepository<PlanTrabajoAccion>
    {
        Task<long> Delete(long idempresa, long idplanaccion);
        Task<PlanTrabajoAccion> Get(long idempresa, long idplanaccion);
    }
}
