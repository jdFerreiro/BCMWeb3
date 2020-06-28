using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PaisRepository : IGenericRepository<CountryCulture>
    {
        Task<long> Delete(string culture, long idpais);
        Task<CountryCulture> Get(string culture, long idpais);
    }
}
