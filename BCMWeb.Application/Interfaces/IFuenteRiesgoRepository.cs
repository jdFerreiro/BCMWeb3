using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IFuenteRiesgoRepository : IGenericRepository<RiskSource>
    {
        Task<long> Delete(long idempresa, string codigofuente);
        Task<RiskSource> Get(long idempresa, string codigofuente);
    }
}
