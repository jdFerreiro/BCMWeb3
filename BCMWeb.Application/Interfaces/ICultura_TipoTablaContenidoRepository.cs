using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoTablaContenidoRepository : IGenericRepository<TableTypeContentCulture>
    {
        Task<long> Delete(string culture, int idtipotablacontenido);
        Task<TableTypeContentCulture> Get(string culture, int idtipotablacontenido);
    }
}
