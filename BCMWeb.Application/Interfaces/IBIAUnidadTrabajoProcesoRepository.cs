using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAUnidadTrabajoProcesoRepository : IGenericRepository<BIAUnidadTrabajoProceso>
    {
        Task<long> Delete(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso);
        Task<BIAUnidadTrabajoProceso> Get(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso);
    }
}
