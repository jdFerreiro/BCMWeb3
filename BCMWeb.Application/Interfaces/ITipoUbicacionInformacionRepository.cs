using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoUbicacionInformacionRepository : IGenericRepository<TipoUbicacionInformacion>
    {
        Task<long> Delete(int idtipoubicacioninformacion);
        Task<TipoUbicacionInformacion> Get(int idtipoubicacioninformacion);
    }
}
