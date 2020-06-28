using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoInterdependenciaRepository : IGenericRepository<InterdependencyType>
    {
        Task<long> Delete(int idtipointerdependencia);
        Task<InterdependencyType> Get(int idtipointerdependencia);
    }
}
