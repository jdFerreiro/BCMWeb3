using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAEventoRiesgoRepository : IGenericRepository<TblBiaeventoRiesgo>
    {
        Task<long> Delete(long ideventoriesgo, long idempresa);
        Task<TblBiaeventoRiesgo> Get(long ideventoriesgo, long idempresa);
    }
}
