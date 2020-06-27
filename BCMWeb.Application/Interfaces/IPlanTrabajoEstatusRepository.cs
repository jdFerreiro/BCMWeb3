using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoEstatusRepository : IGenericRepository<TblPlanTrabajoEstatus>
    {
        Task<long> Delete(short idestatusactividad);
        Task<TblPlanTrabajoEstatus> Get(short idestatusactividad);
    }
}
