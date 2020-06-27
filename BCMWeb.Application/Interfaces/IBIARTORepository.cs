using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIARTORepository : IGenericRepository<TblBiarto>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrto);
        Task<TblBiarto> Get(long idempresa, long iddocumentobia, long idproceso, long idrto);
    }
}
