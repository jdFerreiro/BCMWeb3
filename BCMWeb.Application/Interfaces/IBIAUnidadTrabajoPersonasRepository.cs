using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAUnidadTrabajoPersonasRepository : IGenericRepository<BIAWorkUnitPerson>
    {
        Task<long> Delete(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso, long idunidadpersona, long idclienteproceso);
        Task<BIAWorkUnitPerson> Get(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso, long idunidadpersona, long idclienteproceso);
    }
}
