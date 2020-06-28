using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIADocumentacionRepository : IGenericRepository<BIADocumentation>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long iddocumento);
        Task<BIADocumentation> Get(long idempresa, long iddocumentobia, long idproceso, long iddocumento);
    }
}
