using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAImpactoOperacionalRepository : IGenericRepository<BIAImpactoOperacional>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idimpactooperacional);
        Task<BIAImpactoOperacional> Get(long idempresa, long iddocumentobia, long idproceso, long idimpactooperacional);
    }
}
