using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoResultadoPruebaRepository : IGenericRepository<TblTipoResultadoPrueba>
    {
        Task<long> Delete(int idtiporesultadoprueba);
        Task<TblTipoResultadoPrueba> Get(int idtiporesultadoprueba);
    }
}
