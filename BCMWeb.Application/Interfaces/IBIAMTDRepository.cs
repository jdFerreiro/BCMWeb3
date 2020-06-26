using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAMTDRepository : IGenericRepository<BIAMTD>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idmtd);
        Task<BIAMTD> Get(long idempresa, long iddocumentobia, long idproceso, long idmtd);
    }
}
