using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionTipoNotificacionRepository : IGenericRepository<TblPmtprogramacionTipoNotificacion>
    {
        Task<long> Delete(short idtiponotificacion);
        Task<TblPmtprogramacionTipoNotificacion> Get(short idtiponotificacion);
    }
}
