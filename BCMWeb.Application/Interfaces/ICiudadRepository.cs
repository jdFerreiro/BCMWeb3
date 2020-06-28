using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICiudadRepository : IGenericRepository<City>
    {
        Task<long> Delete(long idpais, long idestado, long idciudad);
        Task<City> Get(long idpais, long idestado, long idciudad);
    }
}
