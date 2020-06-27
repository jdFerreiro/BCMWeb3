using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoContenidoRepository : IGenericRepository<TblDocumentoContenido>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idsubmodulo);
        Task<TblDocumentoContenido> Get(long idempresa, long iddocumento, long idtipodocumento, long idsubmodulo);
    }
}
