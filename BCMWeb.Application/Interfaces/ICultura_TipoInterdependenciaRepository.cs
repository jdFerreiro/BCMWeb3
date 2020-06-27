using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoInterdependenciaRepository : IGenericRepository<TblCulturaTipoInterdependencia>
    {
        Task<long> Delete(string culture, int idtipointerdependencia);
        Task<TblCulturaTipoInterdependencia> Get(string culture, int idtipointerdependencia);
    }
}
