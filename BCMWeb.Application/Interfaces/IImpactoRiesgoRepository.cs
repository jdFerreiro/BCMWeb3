using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IImpactoRiesgoRepository : IGenericRepository<ImpactRisk>
    {
        Task<long> Delete(long idempresa, short idimpacto);
        Task<ImpactRisk> Get(long idempresa, short idimpacto);
    }
}
