using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRecuperacionRecursoRepository : IGenericRepository<BCPRecuperacionRecurso>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idrecuperacionrecurso);
        Task<BCPRecuperacionRecurso> Get(long idempresa, long iddocumentobcp, long idrecuperacionrecurso);
    }
}
