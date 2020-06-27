using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICiudadRepository : IGenericRepository<TblCiudad>
    {
        Task<long> Delete(long idpais, long idestado, long idciudad);
        Task<TblCiudad> Get(long idpais, long idestado, long idciudad);
    }
}
