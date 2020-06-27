using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRespuestaAccionRepository : IGenericRepository<TblBcprespuestaAccion>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprespuestaaccion);
        Task<TblBcprespuestaAccion> Get(long idempresa, long iddocumentobcp, long idbcprespuestaaccion);
    }
}
