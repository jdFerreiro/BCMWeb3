using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoInterdependenciaRepository : IGenericRepository<TipoInterdependencia>
    {
        Task<long> Delete(int idtipointerdependencia);
        Task<TipoInterdependencia> Get(int idtipointerdependencia);
    }
}
