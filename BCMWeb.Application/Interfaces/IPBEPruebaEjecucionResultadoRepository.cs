using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionResultadoRepository : IGenericRepository<PBEPruebaEjecucionResultado>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idcontenido);
        Task<PBEPruebaEjecucionResultado> Get(long idempresa, long idplanificacion, long idcontenido);
    }
}
