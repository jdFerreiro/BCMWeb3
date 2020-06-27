using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoUbicacionInformacionRepository : IGenericRepository<TblTipoUbicacionInformacion>
    {
        Task<long> Delete(int idtipoubicacioninformacion);
        Task<TblTipoUbicacionInformacion> Get(int idtipoubicacioninformacion);
    }
}
