using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PMTProgramacionTipoActualizacionRepository : IGenericRepository<TblCulturaPmtprogramacionTipoActualizacion>
    {
        Task<long> Delete(string culture, short idtipoactualizacion);
        Task<TblCulturaPmtprogramacionTipoActualizacion> Get(string culture, short idtipoactualizacion);
    }
}
