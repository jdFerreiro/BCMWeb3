using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoRepository : IGenericRepository<CountryStateCulture>
    {
        Task<long> Delete(string culture, long idpais, long idestado);
        Task<CountryStateCulture> Get(string culture, long idpais, long idestado);
    }
}
