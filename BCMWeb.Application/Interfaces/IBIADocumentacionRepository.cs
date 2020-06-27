using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIADocumentacionRepository : IGenericRepository<TblBiadocumentacion>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long iddocumento);
        Task<TblBiadocumentacion> Get(long idempresa, long iddocumentobia, long idproceso, long iddocumento);
    }
}
