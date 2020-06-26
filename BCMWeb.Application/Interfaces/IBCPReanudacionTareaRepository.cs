using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPReanudacionTareaRepository : IGenericRepository<BCPReanudacionTarea>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea);
        Task<BCPReanudacionTarea> Get(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea);
    }
}
