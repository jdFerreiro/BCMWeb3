using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIARPORepository : IGenericRepository<TblBiarpo>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrpo);
        Task<TblBiarpo> Get(long idempresa, long iddocumentobia, long idproceso, long idrpo);
    }
}
