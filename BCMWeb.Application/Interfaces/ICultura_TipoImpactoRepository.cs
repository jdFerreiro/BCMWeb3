using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoImpactoRepository : IGenericRepository<Cultura_TipoImpacto>
    {
        Task<long> Delete(string culture, int idtipoimpacto);
        Task<Cultura_TipoImpacto> Get(string culture, int idtipoimpacto);
    }
}
