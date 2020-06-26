using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAProcesoRepository : IGenericRepository<BIAProceso>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso);
        Task<BIAProceso> Get(long idempresa, long iddocumentobia, long idproceso);
    }
}
