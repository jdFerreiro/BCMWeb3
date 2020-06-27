using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAProcesoRepository : IGenericRepository<TblBiaproceso>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso);
        Task<TblBiaproceso> Get(long idempresa, long iddocumentobia, long idproceso);
    }
}
