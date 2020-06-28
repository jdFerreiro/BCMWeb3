using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPDocumentoRepository : IGenericRepository<BCPDocument>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp);
        Task<BCPDocument> Get(long idempresa, long iddocumentobcp);
    }
}
