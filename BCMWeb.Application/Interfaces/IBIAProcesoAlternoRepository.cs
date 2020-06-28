using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAProcesoAlternoRepository : IGenericRepository<BIAAlternateProcess>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idprocesoalterno);
        Task<BIAAlternateProcess> Get(long idempresa, long iddocumentobia, long idproceso, long idprocesoalterno);
    }
}
