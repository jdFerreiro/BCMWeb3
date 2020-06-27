using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoTablaContenidoRepository : IGenericRepository<TblTipoTablaContenido>
    {
        Task<long> Delete(int idtipotablacontenido);
        Task<TblTipoTablaContenido> Get(int idtipotablacontenido);
    }
}
