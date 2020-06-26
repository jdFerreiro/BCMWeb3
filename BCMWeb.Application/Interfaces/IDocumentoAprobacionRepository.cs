using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoAprobacionRepository : IGenericRepository<DocumentoAprobacion>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idaprobacion);
        Task<DocumentoAprobacion> Get(long idempresa, long iddocumento, long idtipodocumento, long idaprobacion);
    }
}
