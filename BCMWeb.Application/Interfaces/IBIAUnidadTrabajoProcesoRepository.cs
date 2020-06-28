using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAUnidadTrabajoProcesoRepository : IGenericRepository<BIAWorkUnitProcess>
    {
        Task<long> Delete(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso);
        Task<BIAWorkUnitProcess> Get(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso);
    }
}
