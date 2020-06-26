using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIADocumentoRepository : IGenericRepository<BIADocumento>
    {
        Task<long> Delete(long idempresa, long iddocumentobia);
        Task<BIADocumento> Get(long idempresa, long iddocumentobia);
    }
}
