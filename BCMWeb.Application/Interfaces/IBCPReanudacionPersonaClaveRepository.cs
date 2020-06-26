using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPReanudacionPersonaClaveRepository : IGenericRepository<BCPReanudacionPersonaClave>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idpersona);
        Task<BCPReanudacionPersonaClave> Get(long idempresa, long iddocumentobcp, long idpersona);
    }
}
