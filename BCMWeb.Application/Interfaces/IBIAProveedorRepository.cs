using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAProveedorRepository : IGenericRepository<BIAProveedor>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idproveedor);
        Task<BIAProveedor> Get(long idempresa, long iddocumentobia, long idproceso, long idproveedor);
    }
}
