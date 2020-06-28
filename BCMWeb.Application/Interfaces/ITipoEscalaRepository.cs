using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoEscalaRepository : IGenericRepository<ScaleType>
    {
        Task<long> Delete(long idempresa, long idtipoescala);
        Task<ScaleType> Get(long idempresa, long idtipoescala);
    }
}
