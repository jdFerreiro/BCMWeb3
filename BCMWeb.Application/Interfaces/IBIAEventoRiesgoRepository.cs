using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAEventoRiesgoRepository : IGenericRepository<BIAEventoRiesgo>
    {
        Task<long> Delete(long ideventoriesgo, long idempresa);
        Task<BIAEventoRiesgo> Get(long ideventoriesgo, long idempresa);
    }
}
