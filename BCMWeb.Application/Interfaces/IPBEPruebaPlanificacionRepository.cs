using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionRepository : IGenericRepository<PPETestSchedule>
    {
        Task<long> Delete(long idempresa, long idplanificacion);
        Task<PPETestSchedule> Get(long idempresa, long idplanificacion);
    }
}
