using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoAuditoriaRepository : IGenericRepository<WorkScheduleAudit>
    {
        Task<long> Delete(long idempresa, long idaccion, long idactividad, long idcambioestado);
        Task<WorkScheduleAudit> Get(long idempresa, long idaccion, long idactividad, long idcambioestado);
    }
}
