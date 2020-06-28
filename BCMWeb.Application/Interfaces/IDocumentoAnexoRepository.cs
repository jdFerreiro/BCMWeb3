using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoAnexoRepository : IGenericRepository<DocumentAttachment>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idanexo);
        Task<DocumentAttachment> Get(long idempresa, long iddocumento, long idtipodocumento, long idanexo);
    }
}
