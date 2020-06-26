using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICiudadRepository : IGenericRepository<Ciudad>
    {
        Task<long> Delete(long idpais, long idestado, long idciudad);
        Task<Ciudad> Get(long idpais, long idestado, long idciudad);
    }
}
