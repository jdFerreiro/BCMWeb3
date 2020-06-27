using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoResultadoPruebaRepository : IGenericRepository<TblCulturaTipoResultadoPrueba>
    {
        Task<long> Delete(string culture, int idtiporesultadoprueba);
        Task<TblCulturaTipoResultadoPrueba> Get(string culture, int idtiporesultadoprueba);
    }
}
