using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAProcesoAlternoRepository : IGenericRepository<BIAProcesoAlterno>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idprocesoalterno);
        Task<BIAProcesoAlterno> Get(long idempresa, long iddocumentobia, long idproceso, long idprocesoalterno);
    }
}
