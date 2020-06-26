using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionMobiliarioRepository : IGenericRepository<BCPRestauracionMobiliario>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idrestauracionmobiliario);
        Task<BCPRestauracionMobiliario> Get(long idempresa, long iddocumentobcp, long idrestauracionmobiliario);
    }
}
