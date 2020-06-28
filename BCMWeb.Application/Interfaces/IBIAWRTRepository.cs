using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAWRTRepository : IGenericRepository<BIAWRT>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idwrt);
        Task<BIAWRT> Get(long idempresa, long iddocumentobia, long idproceso, long idwrt);
    }
}
