using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionMobiliarioRepository : IGenericRepository<BCPRestoreFurniture>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idrestauracionmobiliario);
        Task<BCPRestoreFurniture> Get(long idempresa, long iddocumentobcp, long idrestauracionmobiliario);
    }
}
