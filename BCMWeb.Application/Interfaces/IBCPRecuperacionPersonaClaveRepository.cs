using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRecuperacionPersonaClaveRepository : IGenericRepository<BCPRecuperacionPersonaClave>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idpersona);
        Task<BCPRecuperacionPersonaClave> Get(long idempresa, long iddocumentobcp, long idpersona);
    }
}
