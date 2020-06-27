using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PlanTrabajoEstatusRepository : IGenericRepository<TblCulturaPlanTrabajoEstatus>
    {
        Task<long> Delete(string culture, short idestatusactividad);
        Task<TblCulturaPlanTrabajoEstatus> Get(string culture, short idestatusactividad);
    }
}
