using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoAccionRepository : IGenericRepository<WorkScheduleAction>
    {
        Task<long> Delete(long idempresa, long idplanaccion);
        Task<WorkScheduleAction> Get(long idempresa, long idplanaccion);
    }
}
