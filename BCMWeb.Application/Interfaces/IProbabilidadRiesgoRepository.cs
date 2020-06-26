using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IProbabilidadRiesgoRepository : IGenericRepository<ProbabilidadRiesgo>
    {
        Task<long> Delete(long idempresa, short idprobabilidad);
        Task<ProbabilidadRiesgo> Get(long idempresa, short idprobabilidad);
    }
}
