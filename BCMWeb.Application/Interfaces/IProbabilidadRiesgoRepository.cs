using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IProbabilidadRiesgoRepository : IGenericRepository<RiskProbability>
    {
        Task<long> Delete(long idempresa, short idprobabilidad);
        Task<RiskProbability> Get(long idempresa, short idprobabilidad);
    }
}
