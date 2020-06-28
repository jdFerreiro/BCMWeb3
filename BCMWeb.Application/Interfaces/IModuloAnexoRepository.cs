using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IModuloAnexoRepository : IGenericRepository<MenuAttach>
    {
        Task<long> Delete(long idempresa, long idmodulo, bool negocios, long idanexo);
        Task<MenuAttach> Get(long idempresa, long idmodulo, bool negocios, long idanexo);
    }
}
