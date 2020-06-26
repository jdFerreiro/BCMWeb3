using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoTablaContenidoRepository : IGenericRepository<Cultura_TipoTablaContenido>
    {
        Task<long> Delete(string culture, int idtipotablacontenido);
        Task<Cultura_TipoTablaContenido> Get(string culture, int idtipotablacontenido);
    }
}
