using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPPEFrecuenciaRepository : IGenericRepository<PPEFrecuencia>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idppefrecuencia);
        Task<PPEFrecuencia> Get(long idempresa, long iddocumento, long idtipodocumento, long idppefrecuencia);
    }
}
