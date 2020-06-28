using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionResultadoRepository : IGenericRepository<PPETestExecutionResult>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idcontenido);
        Task<PPETestExecutionResult> Get(long idempresa, long idplanificacion, long idcontenido);
    }
}
