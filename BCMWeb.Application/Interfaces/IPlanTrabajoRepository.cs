using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoRepository : IGenericRepository<WorkSchedule>
    {
        Task<long> Delete(long idempresa, long idaccion, long idactividad);
        Task<WorkSchedule> Get(long idempresa, long idaccion, long idactividad);
    }
}
