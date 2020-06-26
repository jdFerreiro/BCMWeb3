using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIADocumentacionRepository : IGenericRepository<BIADocumentacion>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long iddocumento);
        Task<BIADocumentacion> Get(long idempresa, long iddocumentobia, long idproceso, long iddocumento);
    }
}
