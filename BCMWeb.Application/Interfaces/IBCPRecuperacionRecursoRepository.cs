using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRecuperacionRecursoRepository : IGenericRepository<TblBcprecuperacionRecurso>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idrecuperacionrecurso);
        Task<TblBcprecuperacionRecurso> Get(long idempresa, long iddocumentobcp, long idrecuperacionrecurso);
    }
}
