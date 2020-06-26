using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoResultadoPruebaRepository : IGenericRepository<Cultura_TipoResultadoPrueba>
    {
        Task<long> Delete(string culture, int idtiporesultadoprueba);
        Task<Cultura_TipoResultadoPrueba> Get(string culture, int idtiporesultadoprueba);
    }
}
