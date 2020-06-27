using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IModuloRepository : IGenericRepository<TblModulo>
    {
        Task<long> Delete(long idempresa, long idmodulo);
        Task<TblModulo> Get(long idempresa, long idmodulo);
    }
}
