using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIARespaldoSecundarioRepository : IGenericRepository<BIARespaldoSecundario>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
        Task<BIARespaldoSecundario> Get(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
    }
}
