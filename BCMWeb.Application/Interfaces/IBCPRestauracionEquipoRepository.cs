using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionEquipoRepository : IGenericRepository<TblBcprestauracionEquipo>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracionequipo);
        Task<TblBcprestauracionEquipo> Get(long idempresa, long iddocumentobcp, long idbcprestauracionequipo);
    }
}
