using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ILocalidadRepository : IGenericRepository<TblLocalidad>
    {
        Task<long> Delete(long idempresa, long idlocalidad);
        Task<TblLocalidad> Get(long idempresa, long idlocalidad);
    }
}
