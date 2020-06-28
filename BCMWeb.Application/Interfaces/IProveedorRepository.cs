using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IProveedorRepository : IGenericRepository<Provider>
    {
        Task<long> Delete(long idempresa, long idproveedor);
        Task<Provider> Get(long idempresa, long idproveedor);
    }
}
