using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoAuditoriaRepository : IGenericRepository<PlanTrabajoAuditoria>
    {
        Task<long> Delete(long idempresa, long idaccion, long idactividad, long idcambioestado);
        Task<PlanTrabajoAuditoria> Get(long idempresa, long idaccion, long idactividad, long idcambioestado);
    }
}
