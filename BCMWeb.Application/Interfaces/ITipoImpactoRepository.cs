using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoImpactoRepository : IGenericRepository<TipoImpacto>
    {
        Task<long> Delete(int idtipoimpacto);
        Task<TipoImpacto> Get(int idtipoimpacto);
    }
}
