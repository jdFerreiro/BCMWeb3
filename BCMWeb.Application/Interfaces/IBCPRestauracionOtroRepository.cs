using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionOtroRepository : IGenericRepository<BCPRestoreOther>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracionotro);
        Task<BCPRestoreOther> Get(long idempresa, long iddocumentobcp, long idbcprestauracionotro);
    }
}
