using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPReanudacionPersonaClaveRepository : IGenericRepository<TblBcpreanudacionPersonaClave>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idpersona);
        Task<TblBcpreanudacionPersonaClave> Get(long idempresa, long iddocumentobcp, long idpersona);
    }
}
