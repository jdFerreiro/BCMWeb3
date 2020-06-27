using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRespuestaRecursoRepository : IGenericRepository<TblBcprespuestaRecurso>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idrespuestarecurso);
        Task<TblBcprespuestaRecurso> Get(long idempresa, long iddocumentobcp, long idrespuestarecurso);
    }
}
