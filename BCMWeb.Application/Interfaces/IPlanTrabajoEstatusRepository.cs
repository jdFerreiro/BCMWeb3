using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoEstatusRepository : IGenericRepository<WorkScheduleState>
    {
        Task<long> Delete(short idestatusactividad);
        Task<WorkScheduleState> Get(short idestatusactividad);
    }
}
