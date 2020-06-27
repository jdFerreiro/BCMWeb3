using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ISeveridadRiesgoRepository : IGenericRepository<TblSeveridadRiesgo>
    {
        Task<long> Delete(long idempresa, short idseveridad);
        Task<TblSeveridadRiesgo> Get(long idempresa, short idseveridad);
    }
}
