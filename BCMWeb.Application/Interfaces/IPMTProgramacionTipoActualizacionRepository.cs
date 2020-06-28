using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionTipoActualizacionRepository : IGenericRepository<PMTScheduleUpdateType>
    {
        Task<long> Delete(short idtipoactualizacion);
        Task<PMTScheduleUpdateType> Get(short idtipoactualizacion);
    }
}
