using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAClienteProcesoRepository : IGenericRepository<BIAClienteProceso>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idclienteproceso);
        Task<BIAClienteProceso> Get(long idempresa, long iddocumentobia, long idproceso, long idclienteproceso);
    }
}
