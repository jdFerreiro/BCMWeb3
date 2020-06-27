using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IProductoRepository : IGenericRepository<TblProducto>
    {
        Task<long> Delete(long idempresa, long idproducto);
        Task<TblProducto> Get(long idempresa, long idproducto);
    }
}
