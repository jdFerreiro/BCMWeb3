using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIARespaldoSecundarioRepository : IGenericRepository<TblBiarespaldoSecundario>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
        Task<TblBiarespaldoSecundario> Get(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
    }
}
