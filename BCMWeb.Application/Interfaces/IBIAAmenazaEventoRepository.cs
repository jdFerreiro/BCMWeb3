using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAAmenazaEventoRepository : IGenericRepository<BIAAmenazaEvento>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento);
        Task<BIAAmenazaEvento> Get(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento);
    }
}
