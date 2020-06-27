using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPDocumentoRepository : IGenericRepository<TblBcpdocumento>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp);
        Task<TblBcpdocumento> Get(long idempresa, long iddocumentobcp);
    }
}
