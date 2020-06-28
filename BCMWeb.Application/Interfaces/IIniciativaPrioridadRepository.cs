using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIniciativaPrioridadRepository : IGenericRepository<IntitativePriority>
    {
        Task<long> Delete(long idempresa, short idprioridad);
        Task<IntitativePriority> Get(long idempresa, short idprioridad);
    }
}
