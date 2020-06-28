using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface INivelImpactoRepository : IGenericRepository<ImpactLevel>
    {
        Task<long> Delete(int idnivelimpacto);
        Task<ImpactLevel> Get(int idnivelimpacto);
    }
}
