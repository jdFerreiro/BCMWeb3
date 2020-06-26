using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PMTProgramacionTipoNotificacionRepository : IGenericRepository<Cultura_PMTProgramacionTipoNotificacion>
    {
        Task<long> Delete(string cultura, short idtiponotificacion);
        Task<Cultura_PMTProgramacionTipoNotificacion> Get(string cultura, short idtiponotificacion);
    }
}
