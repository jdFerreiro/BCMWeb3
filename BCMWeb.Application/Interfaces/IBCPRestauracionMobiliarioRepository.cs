using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionMobiliarioRepository : IGenericRepository<TblBcprestauracionMobiliario>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idrestauracionmobiliario);
        Task<TblBcprestauracionMobiliario> Get(long idempresa, long iddocumentobcp, long idrestauracionmobiliario);
    }
}
