using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRecuperacionRecursoRepository : IGenericRepository<BCMRecoverResource>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idrecuperacionrecurso);
        Task<BCMRecoverResource> Get(long idempresa, long iddocumentobcp, long idrecuperacionrecurso);
    }
}
