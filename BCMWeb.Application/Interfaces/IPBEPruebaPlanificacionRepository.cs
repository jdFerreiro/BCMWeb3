using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionRepository : IGenericRepository<PBEPruebaPlanificacion>
    {
        Task<long> Delete(long idempresa, long idplanificacion);
        Task<PBEPruebaPlanificacion> Get(long idempresa, long idplanificacion);
    }
}
