using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPReanudacionTareaActividadRepository : IGenericRepository<BCPRestoreTaskActivity>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea, long idbcpreanudaciontareaactividad);
        Task<BCPRestoreTaskActivity> Get(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea, long idbcpreanudaciontareaactividad);
    }
}
