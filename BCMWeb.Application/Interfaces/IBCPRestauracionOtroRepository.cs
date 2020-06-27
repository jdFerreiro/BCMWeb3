using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionOtroRepository : IGenericRepository<TblBcprestauracionOtro>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracionotro);
        Task<TblBcprestauracionOtro> Get(long idempresa, long iddocumentobcp, long idbcprestauracionotro);
    }
}
