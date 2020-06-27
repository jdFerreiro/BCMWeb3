using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IFuenteRiesgoRepository : IGenericRepository<TblFuenteRiesgo>
    {
        Task<long> Delete(long idempresa, string codigofuente);
        Task<TblFuenteRiesgo> Get(long idempresa, string codigofuente);
    }
}
