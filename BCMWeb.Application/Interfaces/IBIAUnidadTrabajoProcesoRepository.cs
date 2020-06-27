using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAUnidadTrabajoProcesoRepository : IGenericRepository<TblBiaunidadTrabajoProceso>
    {
        Task<long> Delete(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso);
        Task<TblBiaunidadTrabajoProceso> Get(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso);
    }
}
