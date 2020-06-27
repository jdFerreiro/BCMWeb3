using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAImpactoFinancieroRepository : IGenericRepository<TblBiaimpactoFinanciero>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idimpactofinanciero);
        Task<TblBiaimpactoFinanciero> Get(long idempresa, long iddocumentobia, long idproceso, long idimpactofinanciero);
    }
}
