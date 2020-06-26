using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_NivelImpactoRepository : IGenericRepository<Cultura_NivelImpacto>
    {
        Task<long> Delete(string culture, int idnivelimpacto);
        Task<Cultura_NivelImpacto> Get(string culture, int idnivelimpacto);
    }
}
