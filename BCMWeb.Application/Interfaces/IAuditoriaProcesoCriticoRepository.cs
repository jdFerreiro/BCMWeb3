using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IAuditoriaProcesoCriticoRepository : IGenericRepository<TblAuditoriaProcesoCritico>
    {
        Task<long> Delete(long idproceso, long idauditoriaprocesocritico);
        Task<TblAuditoriaProcesoCritico> Get(long idproceso, long idauditoriaprocesocritico);
    }
}
