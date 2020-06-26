using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoContenidoRepository : IGenericRepository<DocumentoContenido>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idsubmodulo);
        Task<DocumentoContenido> Get(long idempresa, long iddocumento, long idtipodocumento, long idsubmodulo);
    }
}
