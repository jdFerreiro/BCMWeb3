using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoTablaContenidoRepository : IGenericRepository<TipoTablaContenido>
    {
        Task<long> Delete(int idtipotablacontenido);
        Task<TipoTablaContenido> Get(int idtipotablacontenido);
    }
}
