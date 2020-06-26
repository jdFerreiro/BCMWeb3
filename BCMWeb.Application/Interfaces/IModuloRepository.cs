using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IModuloRepository : IGenericRepository<Modulo>
    {
        Task<long> Delete(long idempresa, long idmodulo);
        Task<Modulo> Get(long idempresa, long idmodulo);
    }
}
