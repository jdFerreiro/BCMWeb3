using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PMTProgramacionTipoActualizacionRepository : IGenericRepository<Cultura_PMTProgramacionTipoActualizacion>
    {
        Task<long> Delete(string culture, short idtipoactualizacion);
        Task<Cultura_PMTProgramacionTipoActualizacion> Get(string culture, short idtipoactualizacion);
    }
}
