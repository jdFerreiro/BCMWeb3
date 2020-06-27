using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoAprobacionRepository : IGenericRepository<TblDocumentoAprobacion>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idaprobacion);
        Task<TblDocumentoAprobacion> Get(long idempresa, long iddocumento, long idtipodocumento, long idaprobacion);
    }
}
