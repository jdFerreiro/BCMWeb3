using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAMTDRepository : IGenericRepository<TblBiamtd>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idmtd);
        Task<TblBiamtd> Get(long idempresa, long iddocumentobia, long idproceso, long idmtd);
    }
}
