using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIARespaldoPrimarioRepository : IGenericRepository<TblBiarespaldoPrimario>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
        Task<TblBiarespaldoPrimario> Get(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
    }
}
