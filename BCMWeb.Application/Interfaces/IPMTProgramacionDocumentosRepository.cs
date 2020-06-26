using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionDocumentosRepository : IGenericRepository<PMTProgramacionDocumentos>
    {
        Task<long> Delete(long idpmtprogramacion, long idempresa, long idmodulo, long iddocumento);
        Task<PMTProgramacionDocumentos> Get(long idpmtprogramacion, long idempresa, long idmodulo, long iddocumento);
    }
}
