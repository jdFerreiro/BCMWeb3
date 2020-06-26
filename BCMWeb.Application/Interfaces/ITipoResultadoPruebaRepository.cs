using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoResultadoPruebaRepository : IGenericRepository<TipoResultadoPrueba>
    {
        Task<long> Delete(int idtiporesultadoprueba);
        Task<TipoResultadoPrueba> Get(int idtiporesultadoprueba);
    }
}
