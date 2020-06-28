using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoTablaContenidoRepository : IGenericRepository<TableTypeContent>
    {
        Task<long> Delete(int idtipotablacontenido);
        Task<TableTypeContent> Get(int idtipotablacontenido);
    }
}
