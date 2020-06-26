using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRespuestaAccionRepository : IGenericRepository<BCPRespuestaAccion>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprespuestaaccion);
        Task<BCPRespuestaAccion> Get(long idempresa, long iddocumentobcp, long idbcprespuestaaccion);
    }
}
