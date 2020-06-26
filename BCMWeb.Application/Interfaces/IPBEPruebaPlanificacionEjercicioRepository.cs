using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionEjercicioRepository : IGenericRepository<PBEPruebaPlanificacionEjercicio>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio);
        Task<PBEPruebaPlanificacionEjercicio> Get(long idempresa, long idplanificacion, long idejercicio);
    }
}
