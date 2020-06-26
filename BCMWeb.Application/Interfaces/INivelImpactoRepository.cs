using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface INivelImpactoRepository : IGenericRepository<NivelImpacto>
    {
        Task<long> Delete(int idnivelimpacto);
        Task<NivelImpacto> Get(int idnivelimpacto);
    }
}
