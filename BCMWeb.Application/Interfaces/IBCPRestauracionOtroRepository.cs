using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionOtroRepository : IGenericRepository<BCPRestauracionOtro>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracionotro);
        Task<BCPRestauracionOtro> Get(long idempresa, long iddocumentobcp, long idbcprestauracionotro);
    }
}
