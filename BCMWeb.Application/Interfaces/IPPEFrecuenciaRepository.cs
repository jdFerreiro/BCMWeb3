using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPPEFrecuenciaRepository : IGenericRepository<PPEFrecuency>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idppefrecuencia);
        Task<PPEFrecuency> Get(long idempresa, long iddocumento, long idtipodocumento, long idppefrecuencia);
    }
}
