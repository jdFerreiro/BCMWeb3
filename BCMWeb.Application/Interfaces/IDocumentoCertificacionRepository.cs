using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoCertificacionRepository : IGenericRepository<TblDocumentoCertificacion>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idcertificacion);
        Task<TblDocumentoCertificacion> Get(long idempresa, long iddocumento, long idtipodocumento, long idcertificacion);
    }
}
