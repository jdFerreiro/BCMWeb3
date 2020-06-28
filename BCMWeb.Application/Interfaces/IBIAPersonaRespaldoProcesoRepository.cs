using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAPersonaRespaldoProcesoRepository : IGenericRepository<BIAProcessBackupPerson>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idpersona, long idproceso);
        Task<BIAProcessBackupPerson> Get(long idempresa, long iddocumentobia, long idpersona, long idproceso);
    }
}
