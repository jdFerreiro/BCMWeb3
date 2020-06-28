using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEstadoRiesgoRepository : IGenericRepository<RiskState>
    {
        Task<long> Delete(long idempresa, short idestadoriesgo);
        Task<RiskState> Get(long idempresa, short idestadoriesgo);
    }
}
