using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPReanudacionTareaRepository : IGenericRepository<BCPRestoreTask>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea);
        Task<BCPRestoreTask> Get(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea);
    }
}
