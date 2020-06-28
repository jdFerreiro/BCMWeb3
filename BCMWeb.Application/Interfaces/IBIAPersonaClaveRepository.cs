using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAPersonaClaveRepository : IGenericRepository<BIAKeyPerson>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idpersonaclave);
        Task<BIAKeyPerson> Get(long idempresa, long iddocumentobia, long idproceso, long idpersonaclave);
    }
}
