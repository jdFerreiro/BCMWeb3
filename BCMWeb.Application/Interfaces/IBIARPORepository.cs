using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIARPORepository : IGenericRepository<BIARPO>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrpo);
        Task<BIARPO> Get(long idempresa, long iddocumentobia, long idproceso, long idrpo);
    }
}
