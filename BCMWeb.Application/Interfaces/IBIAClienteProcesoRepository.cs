using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAClienteProcesoRepository : IGenericRepository<BIAProcessClient>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idclienteproceso);
        Task<BIAProcessClient> Get(long idempresa, long iddocumentobia, long idproceso, long idclienteproceso);
    }
}
