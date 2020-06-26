using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoEstatusRepository : IGenericRepository<PlanTrabajoEstatus>
    {
        Task<long> Delete(short idestatusactividad);
        Task<PlanTrabajoEstatus> Get(short idestatusactividad);
    }
}
