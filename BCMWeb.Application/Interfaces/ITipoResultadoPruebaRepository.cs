using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoResultadoPruebaRepository : IGenericRepository<TestResultType>
    {
        Task<long> Delete(int idtiporesultadoprueba);
        Task<TestResultType> Get(int idtiporesultadoprueba);
    }
}
