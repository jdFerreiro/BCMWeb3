using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEstadoRepository : IGenericRepository<CountryState>
    {
        Task<long> Delete(long idpais, long idestado);
        Task<CountryState> Get(long idpais, long idestado);
    }
}
