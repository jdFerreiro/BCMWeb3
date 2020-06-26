using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ILocalidadRepository : IGenericRepository<Localidad>
    {
        Task<long> Delete(long idempresa, long idlocalidad);
        Task<Localidad> Get(long idempresa, long idlocalidad);
    }
}
