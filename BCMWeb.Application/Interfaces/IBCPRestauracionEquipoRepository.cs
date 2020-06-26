using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionEquipoRepository : IGenericRepository<BCPRestauracionEquipo>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracionequipo);
        Task<BCPRestauracionEquipo> Get(long idempresa, long iddocumentobcp, long idbcprestauracionequipo);
    }
}
