using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoUbicacionInformacionRepository : IGenericRepository<LocationTypeInformation>
    {
        Task<long> Delete(int idtipoubicacioninformacion);
        Task<LocationTypeInformation> Get(int idtipoubicacioninformacion);
    }
}
