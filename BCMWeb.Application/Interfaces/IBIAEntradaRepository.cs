using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAEntradaRepository : IGenericRepository<BIAInput>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long identrada);
        Task<BIAInput> Get(long idempresa, long iddocumentobia, long idproceso, long identrada);
    }
}
