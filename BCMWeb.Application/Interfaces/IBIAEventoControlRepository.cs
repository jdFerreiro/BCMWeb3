using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAEventoControlRepository : IGenericRepository<TblBiaeventoControl>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento, long ideventocontrol);
        Task<TblBiaeventoControl> Get(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento, long ideventocontrol);
    }
}
