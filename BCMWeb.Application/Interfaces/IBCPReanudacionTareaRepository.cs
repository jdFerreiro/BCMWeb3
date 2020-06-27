using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPReanudacionTareaRepository : IGenericRepository<TblBcpreanudacionTarea>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea);
        Task<TblBcpreanudacionTarea> Get(long idempresa, long iddocumentobcp, long idbcpreanudaciontarea);
    }
}
