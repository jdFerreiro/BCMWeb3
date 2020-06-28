using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_NivelImpactoRepository : IGenericRepository<ImpactLevelCulture>
    {
        Task<long> Delete(string culture, int idnivelimpacto);
        Task<ImpactLevelCulture> Get(string culture, int idnivelimpacto);
    }
}
