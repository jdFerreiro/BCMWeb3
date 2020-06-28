using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PlanTrabajoEstatusRepository : IGenericRepository<WorkScheduleStateCulture>
    {
        Task<long> Delete(string culture, short idestatusactividad);
        Task<WorkScheduleStateCulture> Get(string culture, short idestatusactividad);
    }
}
