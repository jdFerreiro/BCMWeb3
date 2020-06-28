using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoEntrevistaRepository : IGenericRepository<DocumentInterview>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long identrevista);
        Task<DocumentInterview> Get(long idempresa, long iddocumento, long idtipodocumento, long identrevista);
    }
}
