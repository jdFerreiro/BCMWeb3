using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionDocumentosRepository : IGenericRepository<PMTScheduleDocument>
    {
        Task<long> Delete(long idpmtprogramacion, long idempresa, long idmodulo, long iddocumento);
        Task<PMTScheduleDocument> Get(long idpmtprogramacion, long idempresa, long idmodulo, long iddocumento);
    }
}
