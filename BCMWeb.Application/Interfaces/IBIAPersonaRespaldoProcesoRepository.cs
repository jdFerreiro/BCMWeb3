using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAPersonaRespaldoProcesoRepository : IGenericRepository<BIAPersonaRespaldoProceso>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idpersona, long idproceso);
        Task<BIAPersonaRespaldoProceso> Get(long idempresa, long iddocumentobia, long idpersona, long idproceso);
    }
}
