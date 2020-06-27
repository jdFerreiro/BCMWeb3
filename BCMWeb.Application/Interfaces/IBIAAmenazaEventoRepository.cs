using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAAmenazaEventoRepository : IGenericRepository<TblBiaamenazaEvento>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento);
        Task<TblBiaamenazaEvento> Get(long idempresa, long iddocumentobia, long idproceso, long idamenaza, long idamenazaevento);
    }
}
