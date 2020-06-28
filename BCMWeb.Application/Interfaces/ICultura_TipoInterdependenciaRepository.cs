using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoInterdependenciaRepository : IGenericRepository<InterdependencyTypeCulture>
    {
        Task<long> Delete(string culture, int idtipointerdependencia);
        Task<InterdependencyTypeCulture> Get(string culture, int idtipointerdependencia);
    }
}
