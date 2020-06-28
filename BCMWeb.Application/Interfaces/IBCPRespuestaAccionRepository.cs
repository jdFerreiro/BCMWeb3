using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRespuestaAccionRepository : IGenericRepository<BCPRestoreAction>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprespuestaaccion);
        Task<BCPRestoreAction> Get(long idempresa, long iddocumentobcp, long idbcprespuestaaccion);
    }
}
