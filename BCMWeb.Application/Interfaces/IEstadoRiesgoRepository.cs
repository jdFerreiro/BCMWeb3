using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEstadoRiesgoRepository : IGenericRepository<EstadoRiesgo>
    {
        Task<long> Delete(long idempresa, short idestadoriesgo);
        Task<EstadoRiesgo> Get(long idempresa, short idestadoriesgo);
    }
}
