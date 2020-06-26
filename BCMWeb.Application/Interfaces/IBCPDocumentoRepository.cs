using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPDocumentoRepository : IGenericRepository<BCPDocumento>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp);
        Task<BCPDocumento> Get(long idempresa, long iddocumentobcp);
    }
}
