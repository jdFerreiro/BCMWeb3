using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionTipoNotificacionRepository : IGenericRepository<PMTScheduleNotificationType>
    {
        Task<long> Delete(short idtiponotificacion);
        Task<PMTScheduleNotificationType> Get(short idtiponotificacion);
    }
}
