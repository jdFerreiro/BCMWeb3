using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionTipoNotificacionRepository : IGenericRepository<PMTProgramacionTipoNotificacion>
    {
        Task<long> Delete(short idtiponotificacion);
        Task<PMTProgramacionTipoNotificacion> Get(short idtiponotificacion);
    }
}
