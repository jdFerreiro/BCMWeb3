using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionDocumentosRepository : IGenericRepository<TblPmtprogramacionDocumentos>
    {
        Task<long> Delete(long idpmtprogramacion, long idempresa, long idmodulo, long iddocumento);
        Task<TblPmtprogramacionDocumentos> Get(long idpmtprogramacion, long idempresa, long idmodulo, long iddocumento);
    }
}
