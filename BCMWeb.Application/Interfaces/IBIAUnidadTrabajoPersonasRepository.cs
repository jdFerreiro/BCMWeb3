using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAUnidadTrabajoPersonasRepository : IGenericRepository<BIAUnidadTrabajoPersonas>
    {
        Task<long> Delete(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso, long idunidadpersona, long idclienteproceso);
        Task<BIAUnidadTrabajoPersonas> Get(long idempresa, long idunidadtrabajo, long idunidadtrabajoproceso, long idunidadpersona, long idclienteproceso);
    }
}
