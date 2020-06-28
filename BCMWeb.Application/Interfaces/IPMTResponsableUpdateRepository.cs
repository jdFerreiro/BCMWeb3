using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTResponsableUpdateRepository : IGenericRepository<PMTUpdateResponsable>
    {
        Task<long> Delete(long idempresa, long idmodulo, long idmensaje);
        Task<PMTUpdateResponsable> Get(long idempresa, long idmodulo, long idmensaje);
    }
}
