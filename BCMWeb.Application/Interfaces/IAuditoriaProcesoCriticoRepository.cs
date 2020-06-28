using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IAuditoriaProcesoCriticoRepository : IGenericRepository<AuditCriticalProcess>
    {
        Task<long> Delete(long idproceso, long idauditoriaprocesocritico);
        Task<AuditCriticalProcess> Get(long idproceso, long idauditoriaprocesocritico);
    }
}
