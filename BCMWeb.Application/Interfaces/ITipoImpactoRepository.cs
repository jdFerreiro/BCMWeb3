using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoImpactoRepository : IGenericRepository<ImpactType>
    {
        Task<long> Delete(int idtipoimpacto);
        Task<ImpactType> Get(int idtipoimpacto);
    }
}
