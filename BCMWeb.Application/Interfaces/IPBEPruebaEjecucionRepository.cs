using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionRepository : IGenericRepository<PPETestExecution>
    {
        Task<long> Delete(long idempresa, long idplanificacion);
        Task<PPETestExecution> Get(long idempresa, long idplanificacion);
    }
}
