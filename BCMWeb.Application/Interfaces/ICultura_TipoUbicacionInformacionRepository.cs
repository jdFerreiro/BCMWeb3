using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoUbicacionInformacionRepository : IGenericRepository<LocationTypeInformationCulture>
    {
        Task<long> Delete(string culture, int idtipoubicacioninformacion);
        Task<LocationTypeInformationCulture> Get(string culture, int idtipoubicacioninformacion);
    }
}
