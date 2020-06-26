using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAGranImpactoRepository : IGenericRepository<BIAGranImpacto>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idgranimpacto, int idmes);
        Task<BIAGranImpacto> Get(long idempresa, long iddocumentobia, long idproceso, long idgranimpacto, int idmes);
    }
}
