using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IProductoRepository : IGenericRepository<Product>
    {
        Task<long> Delete(long idempresa, long idproducto);
        Task<Product> Get(long idempresa, long idproducto);
    }
}
