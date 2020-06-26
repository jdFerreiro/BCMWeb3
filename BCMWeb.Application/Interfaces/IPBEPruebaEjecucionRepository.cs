using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionRepository : IGenericRepository<PBEPruebaEjecucion>
    {
        Task<long> Delete(long idempresa, long idplanificacion);
        Task<PBEPruebaEjecucion> Get(long idempresa, long idplanificacion);
    }
}
