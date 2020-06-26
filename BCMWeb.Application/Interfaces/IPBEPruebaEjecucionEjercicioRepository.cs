using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionEjercicioRepository : IGenericRepository<PBEPruebaEjecucionEjercicio>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio);
        Task<PBEPruebaEjecucionEjercicio> Get(long idempresa, long idplanificacion, long idejercicio);
    }
}
