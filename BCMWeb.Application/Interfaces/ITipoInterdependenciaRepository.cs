using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoInterdependenciaRepository : IGenericRepository<TblTipoInterdependencia>
    {
        Task<long> Delete(int idtipointerdependencia);
        Task<TblTipoInterdependencia> Get(int idtipointerdependencia);
    }
}
