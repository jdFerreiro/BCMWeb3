using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAInterdependenciaRepository : IGenericRepository<BIAInterdependecy>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idinterdependencia);
        Task<BIAInterdependecy> Get(long idempresa, long iddocumentobia, long idproceso, long idinterdependencia);
    }
}
