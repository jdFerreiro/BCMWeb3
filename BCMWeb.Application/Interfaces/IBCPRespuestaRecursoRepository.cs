using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRespuestaRecursoRepository : IGenericRepository<BCPRespuestaRecurso>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idrespuestarecurso);
        Task<BCPRespuestaRecurso> Get(long idempresa, long iddocumentobcp, long idrespuestarecurso);
    }
}
