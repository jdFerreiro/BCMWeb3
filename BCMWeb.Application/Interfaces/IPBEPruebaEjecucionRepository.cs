using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionRepository : IGenericRepository<TblPbepruebaEjecucion>
    {
        Task<long> Delete(long idempresa, long idplanificacion);
        Task<TblPbepruebaEjecucion> Get(long idempresa, long idplanificacion);
    }
}
