using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoUbicacionInformacionRepository : IGenericRepository<Cultura_TipoUbicacionInformacion>
    {
        Task<long> Delete(string culture, int idtipoubicacioninformacion);
        Task<Cultura_TipoUbicacionInformacion> Get(string culture, int idtipoubicacioninformacion);
    }
}
