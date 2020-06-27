using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAGranImpactoRepository : IGenericRepository<TblBiagranImpacto>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idgranimpacto, int idmes);
        Task<TblBiagranImpacto> Get(long idempresa, long iddocumentobia, long idproceso, long idgranimpacto, int idmes);
    }
}
