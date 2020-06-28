using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAEventoControlRepository : IGenericRepository<BIAControlEvent>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento, long ideventocontrol);
        Task<BIAControlEvent> Get(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento, long ideventocontrol);
    }
}
