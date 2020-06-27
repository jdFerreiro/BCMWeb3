using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PMTProgramacionTipoNotificacionRepository : IGenericRepository<TblCulturaPmtprogramacionTipoNotificacion>
    {
        Task<long> Delete(string cultura, short idtiponotificacion);
        Task<TblCulturaPmtprogramacionTipoNotificacion> Get(string cultura, short idtiponotificacion);
    }
}
