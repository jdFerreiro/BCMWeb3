using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IProveedorRepository : IGenericRepository<TblProveedor>
    {
        Task<long> Delete(long idempresa, long idproveedor);
        Task<TblProveedor> Get(long idempresa, long idproveedor);
    }
}
