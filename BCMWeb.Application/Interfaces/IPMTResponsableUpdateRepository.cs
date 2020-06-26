using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTResponsableUpdateRepository : IGenericRepository<PMTResponsableUpdate>
    {
        Task<long> Delete(long idempresa, long idmodulo, long idmensaje);
        Task<PMTResponsableUpdate> Get(long idempresa, long idmodulo, long idmensaje);
    }
}
