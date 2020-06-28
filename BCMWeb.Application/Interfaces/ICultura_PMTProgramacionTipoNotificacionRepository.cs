using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PMTProgramacionTipoNotificacionRepository : IGenericRepository<PMTScheduleNotificationTypeCulture>
    {
        Task<long> Delete(string cultura, short idtiponotificacion);
        Task<PMTScheduleNotificationTypeCulture> Get(string cultura, short idtiponotificacion);
    }
}
