using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAImpactoOperacionalRepository : IGenericRepository<BIAOperationalImpact>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idimpactooperacional);
        Task<BIAOperationalImpact> Get(long idempresa, long iddocumentobia, long idproceso, long idimpactooperacional);
    }
}
