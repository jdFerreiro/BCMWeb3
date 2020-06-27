using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAPersonaRespaldoProcesoRepository : IGenericRepository<TblBiapersonaRespaldoProceso>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idpersona, long idproceso);
        Task<TblBiapersonaRespaldoProceso> Get(long idempresa, long iddocumentobia, long idpersona, long idproceso);
    }
}
