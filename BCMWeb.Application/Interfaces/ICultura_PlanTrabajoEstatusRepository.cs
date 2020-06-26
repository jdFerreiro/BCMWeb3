using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PlanTrabajoEstatusRepository : IGenericRepository<Cultura_PlanTrabajoEstatus>
    {
        Task<long> Delete(string culture, short idestatusactividad);
        Task<Cultura_PlanTrabajoEstatus> Get(string culture, short idestatusactividad);
    }
}
