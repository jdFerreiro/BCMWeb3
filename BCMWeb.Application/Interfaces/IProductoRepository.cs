using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IProductoRepository : IGenericRepository<Producto>
    {
        Task<long> Delete(long idempresa, long idproducto);
        Task<Producto> Get(long idempresa, long idproducto);
    }
}
