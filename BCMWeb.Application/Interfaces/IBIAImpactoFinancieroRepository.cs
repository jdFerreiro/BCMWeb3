using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAImpactoFinancieroRepository : IGenericRepository<BIAImpactoFinanciero>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idimpactofinanciero);
        Task<BIAImpactoFinanciero> Get(long idempresa, long iddocumentobia, long idproceso, long idimpactofinanciero);
    }
}
