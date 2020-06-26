using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoProcesoRepository : IGenericRepository<Cultura_EstadoProceso>
    {
        Task<long> Delete(string culture, long idestadoproceso);
        Task<Cultura_EstadoProceso> Get(string culture, long idestadoproceso);
    }
}
