using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRespuestaRecursoRepository : IGenericRepository<BCPAnswerResource>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idrespuestarecurso);
        Task<BCPAnswerResource> Get(long idempresa, long iddocumentobcp, long idrespuestarecurso);
    }
}
