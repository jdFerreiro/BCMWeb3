using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IControlRiesgoRepository : IGenericRepository<RiskControl>
    {
        Task<long> Delete(long idempresa, short idcontrol);
        Task<RiskControl> Get(long idempresa, short idcontrol);
    }
}
