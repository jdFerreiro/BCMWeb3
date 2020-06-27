using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoUbicacionInformacionRepository : IGenericRepository<TblCulturaTipoUbicacionInformacion>
    {
        Task<long> Delete(string culture, int idtipoubicacioninformacion);
        Task<TblCulturaTipoUbicacionInformacion> Get(string culture, int idtipoubicacioninformacion);
    }
}
