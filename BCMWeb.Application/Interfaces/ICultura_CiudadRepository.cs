using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_CiudadRepository : IGenericRepository<TblCulturaCiudad>
    {
        Task<long> Delete(string culture, long idpais, long idestado, long idciudad);
        Task<TblCulturaCiudad> Get(string culture, long idpais, long idestado, long idciudad);
    }
}
