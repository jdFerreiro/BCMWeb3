using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionInfraestructuraRepository : IGenericRepository<BCPRestoreInfraestructure>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracioninfraestructura);
        Task<BCPRestoreInfraestructure> Get(long idempresa, long iddocumentobcp, long idbcprestauracioninfraestructura);
    }
}
