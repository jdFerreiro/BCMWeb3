using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAGranImpactoRepository : IGenericRepository<BIABigImpact>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idgranimpacto, int idmes);
        Task<BIABigImpact> Get(long idempresa, long iddocumentobia, long idproceso, long idgranimpacto, int idmes);
    }
}
