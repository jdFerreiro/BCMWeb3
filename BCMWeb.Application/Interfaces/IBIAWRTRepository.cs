using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAWRTRepository : IGenericRepository<TblBiawrt>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idwrt);
        Task<TblBiawrt> Get(long idempresa, long iddocumentobia, long idproceso, long idwrt);
    }
}
