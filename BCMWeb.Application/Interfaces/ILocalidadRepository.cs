using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ILocalidadRepository : IGenericRepository<Location>
    {
        Task<long> Delete(long idempresa, long idlocalidad);
        Task<Location> Get(long idempresa, long idlocalidad);
    }
}
