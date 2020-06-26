using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPReanudacionTareaActividadRepository : IGenericRepository<BCPReanudacionTareaActividad>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea, long idbcpreanudaciontareaactividad);
        Task<BCPReanudacionTareaActividad> Get(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea, long idbcpreanudaciontareaactividad);
    }
}
