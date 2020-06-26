using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_CiudadRepository : IGenericRepository<Cultura_Ciudad>
    {
        Task<long> Delete(string culture, long idpais, long idestado, long idciudad);
        Task<Cultura_Ciudad> Get(string culture, long idpais, long idestado, long idciudad);
    }
}
