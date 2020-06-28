using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAImpactoFinancieroRepository : IGenericRepository<BIAFiancialImpact>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idimpactofinanciero);
        Task<BIAFiancialImpact> Get(long idempresa, long iddocumentobia, long idproceso, long idimpactofinanciero);
    }
}
