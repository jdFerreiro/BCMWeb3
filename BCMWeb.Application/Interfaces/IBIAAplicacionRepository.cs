using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAAplicacionRepository : IGenericRepository<BIAApp>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idaplicacion);
        Task<BIAApp> Get(long idempresa, long iddocumentobia, long idproceso, long idaplicacion);
    }
}
