using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PMTProgramacionTipoActualizacionRepository : IGenericRepository<PMTScheduleUpdateTypeCulture>
    {
        Task<long> Delete(string culture, short idtipoactualizacion);
        Task<PMTScheduleUpdateTypeCulture> Get(string culture, short idtipoactualizacion);
    }
}
