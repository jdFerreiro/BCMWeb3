using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoProcesoRepository : IGenericRepository<ProcessStateCulture>
    {
        Task<long> Delete(string culture, long idestadoproceso);
        Task<ProcessStateCulture> Get(string culture, long idestadoproceso);
    }
}
