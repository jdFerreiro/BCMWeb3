using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIARespaldoSecundarioRepository : IGenericRepository<BIASecondaryBackup>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
        Task<BIASecondaryBackup> Get(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
    }
}
