using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoRepository : IGenericRepository<PlanTrabajo>
    {
        Task<long> Delete(long idempresa, long idaccion, long idactividad);
        Task<PlanTrabajo> Get(long idempresa, long idaccion, long idactividad);
    }
}
