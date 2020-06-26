using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IModuloAnexoRepository : IGenericRepository<ModuloAnexo>
    {
        Task<long> Delete(long idempresa, long idmodulo, bool negocios, long idanexo);
        Task<ModuloAnexo> Get(long idempresa, long idmodulo, bool negocios, long idanexo);
    }
}
