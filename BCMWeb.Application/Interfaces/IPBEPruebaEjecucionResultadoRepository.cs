using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionResultadoRepository : IGenericRepository<TblPbepruebaEjecucionResultado>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idcontenido);
        Task<TblPbepruebaEjecucionResultado> Get(long idempresa, long idplanificacion, long idcontenido);
    }
}
