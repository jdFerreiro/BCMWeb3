using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAEntradaRepository : IGenericRepository<BIAEntrada>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long identrada);
        Task<BIAEntrada> Get(long idempresa, long iddocumentobia, long idproceso, long identrada);
    }
}
