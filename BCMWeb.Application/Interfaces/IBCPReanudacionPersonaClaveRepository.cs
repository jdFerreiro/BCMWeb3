using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPReanudacionPersonaClaveRepository : IGenericRepository<BCPRestartVIPPerson>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idpersona);
        Task<BCPRestartVIPPerson> Get(long idempresa, long iddocumentobcp, long idpersona);
    }
}
