using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionEquipoRepository : IGenericRepository<BCPRestoreKit>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracionequipo);
        Task<BCPRestoreKit> Get(long idempresa, long iddocumentobcp, long idbcprestauracionequipo);
    }
}
