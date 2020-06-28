using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIADocumentoRepository : IGenericRepository<BIADocument>
    {
        Task<long> Delete(long idempresa, long iddocumentobia);
        Task<BIADocument> Get(long idempresa, long iddocumentobia);
    }
}
