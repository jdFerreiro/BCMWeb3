using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRecuperacionPersonaClaveRepository : IGenericRepository<BCPRestoreKeyPerson>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idpersona);
        Task<BCPRestoreKeyPerson> Get(long idempresa, long iddocumentobcp, long idpersona);
    }
}
