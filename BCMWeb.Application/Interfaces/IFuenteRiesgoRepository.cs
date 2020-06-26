using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IFuenteRiesgoRepository : IGenericRepository<FuenteRiesgo>
    {
        Task<long> Delete(long idempresa, string codigofuente);
        Task<FuenteRiesgo> Get(long idempresa, string codigofuente);
    }
}
