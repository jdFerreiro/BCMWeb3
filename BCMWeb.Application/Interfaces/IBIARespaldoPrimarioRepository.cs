using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIARespaldoPrimarioRepository : IGenericRepository<BIARespaldoPrimario>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
        Task<BIARespaldoPrimario> Get(long idempresa, long iddocumentobia, long idproceso, long idrespaldo);
    }
}
