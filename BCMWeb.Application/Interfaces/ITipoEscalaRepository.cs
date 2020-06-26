using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoEscalaRepository : IGenericRepository<TipoEscala>
    {
        Task<long> Delete(long idempresa, long idtipoescala);
        Task<TipoEscala> Get(long idempresa, long idtipoescala);
    }
}
