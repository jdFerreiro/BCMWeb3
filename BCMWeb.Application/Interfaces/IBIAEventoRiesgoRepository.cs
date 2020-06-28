using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAEventoRiesgoRepository : IGenericRepository<BIARiskEvent>
    {
        Task<long> Delete(long ideventoriesgo, long idempresa);
        Task<BIARiskEvent> Get(long ideventoriesgo, long idempresa);
    }
}
