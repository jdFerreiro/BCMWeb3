using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRecuperacionPersonaClaveRepository : IGenericRepository<TblBcprecuperacionPersonaClave>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idpersona);
        Task<TblBcprecuperacionPersonaClave> Get(long idempresa, long iddocumentobcp, long idpersona);
    }
}
