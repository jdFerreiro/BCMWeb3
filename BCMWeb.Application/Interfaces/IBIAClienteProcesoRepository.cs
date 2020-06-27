using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAClienteProcesoRepository : IGenericRepository<TblBiaclienteProceso>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idclienteproceso);
        Task<TblBiaclienteProceso> Get(long idempresa, long iddocumentobia, long idproceso, long idclienteproceso);
    }
}
