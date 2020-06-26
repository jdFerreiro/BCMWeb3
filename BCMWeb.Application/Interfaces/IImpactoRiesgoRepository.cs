using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IImpactoRiesgoRepository : IGenericRepository<ImpactoRiesgo>
    {
        Task<long> Delete(long idempresa, short idimpacto);
        Task<ImpactoRiesgo> Get(long idempresa, short idimpacto);
    }
}
