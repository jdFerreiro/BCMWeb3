using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAProveedorRepository : IGenericRepository<BIAProvider>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idproveedor);
        Task<BIAProvider> Get(long idempresa, long iddocumentobia, long idproceso, long idproveedor);
    }
}
