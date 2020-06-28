using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoResultadoPruebaRepository : IGenericRepository<TestResultTypeCulture>
    {
        Task<long> Delete(string culture, int idtiporesultadoprueba);
        Task<TestResultTypeCulture> Get(string culture, int idtiporesultadoprueba);
    }
}
