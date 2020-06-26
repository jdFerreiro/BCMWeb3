using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoInterdependenciaRepository : IGenericRepository<Cultura_TipoInterdependencia>
    {
        Task<long> Delete(string culture, int idtipointerdependencia);
        Task<Cultura_TipoInterdependencia> Get(string culture, int idtipointerdependencia);
    }
}
