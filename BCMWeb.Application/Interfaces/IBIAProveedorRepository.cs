using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAProveedorRepository : IGenericRepository<TblBiaproveedor>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idproveedor);
        Task<TblBiaproveedor> Get(long idempresa, long iddocumentobia, long idproceso, long idproveedor);
    }
}
