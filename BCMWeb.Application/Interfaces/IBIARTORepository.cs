using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIARTORepository : IGenericRepository<BIARTO>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrto);
        Task<BIARTO> Get(long idempresa, long iddocumentobia, long idproceso, long idrto);
    }
}
