using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IProveedorRepository : IGenericRepository<Proveedor>
    {
        Task<long> Delete(long idempresa, long idproveedor);
        Task<Proveedor> Get(long idempresa, long idproveedor);
    }
}
