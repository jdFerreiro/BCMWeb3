using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAInterdependenciaRepository : IGenericRepository<BIAInterdependencia>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idinterdependencia);
        Task<BIAInterdependencia> Get(long idempresa, long iddocumentobia, long idproceso, long idinterdependencia);
    }
}
