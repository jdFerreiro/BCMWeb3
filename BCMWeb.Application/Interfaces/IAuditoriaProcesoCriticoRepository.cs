using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IAuditoriaProcesoCriticoRepository : IGenericRepository<AuditoriaProcesoCritico>
    {
        Task<long> Delete(long idproceso, long idauditoriaprocesocritico);
        Task<AuditoriaProcesoCritico> Get(long idproceso, long idauditoriaprocesocritico);
    }
}
