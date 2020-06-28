using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ISeveridadRiesgoRepository : IGenericRepository<RiskSeverity>
    {
        Task<long> Delete(long idempresa, short idseveridad);
        Task<RiskSeverity> Get(long idempresa, short idseveridad);
    }
}
