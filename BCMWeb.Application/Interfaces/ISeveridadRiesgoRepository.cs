using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ISeveridadRiesgoRepository : IGenericRepository<SeveridadRiesgo>
    {
        Task<long> Delete(long idempresa, short idseveridad);
        Task<SeveridadRiesgo> Get(long idempresa, short idseveridad);
    }
}
