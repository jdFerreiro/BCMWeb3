using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IModuloRepository : IGenericRepository<MenuOption>
    {
        Task<long> Delete(long idempresa, long idmodulo);
        Task<MenuOption> Get(long idempresa, long idmodulo);
    }
}
