using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionInfraestructuraRepository : IGenericRepository<BCPRestauracionInfraestructura>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracioninfraestructura);
        Task<BCPRestauracionInfraestructura> Get(long idempresa, long iddocumentobcp, long idbcprestauracioninfraestructura);
    }
}
