using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAEntradaRepository : IGenericRepository<TblBiaentrada>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long identrada);
        Task<TblBiaentrada> Get(long idempresa, long iddocumentobia, long idproceso, long identrada);
    }
}
