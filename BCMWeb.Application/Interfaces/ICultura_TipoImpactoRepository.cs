using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoImpactoRepository : IGenericRepository<ImpactTypeCulture>
    {
        Task<long> Delete(string culture, int idtipoimpacto);
        Task<ImpactTypeCulture> Get(string culture, int idtipoimpacto);
    }
}
