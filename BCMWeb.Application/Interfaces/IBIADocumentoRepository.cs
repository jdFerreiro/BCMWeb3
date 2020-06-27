using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIADocumentoRepository : IGenericRepository<TblBiadocumento>
    {
        Task<long> Delete(long idempresa, long iddocumentobia);
        Task<TblBiadocumento> Get(long idempresa, long iddocumentobia);
    }
}
