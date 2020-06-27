using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTResponsableUpdateRepository : IGenericRepository<TblPmtresponsableUpdate>
    {
        Task<long> Delete(long idempresa, long idmodulo, long idmensaje);
        Task<TblPmtresponsableUpdate> Get(long idempresa, long idmodulo, long idmensaje);
    }
}
