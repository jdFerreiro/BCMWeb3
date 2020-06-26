using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionTipoActualizacionRepository : IGenericRepository<PMTProgramacionTipoActualizacion>
    {
        Task<long> Delete(short idtipoactualizacion);
        Task<PMTProgramacionTipoActualizacion> Get(short idtipoactualizacion);
    }
}
