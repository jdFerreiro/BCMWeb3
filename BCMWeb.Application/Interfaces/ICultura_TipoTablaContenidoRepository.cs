using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoTablaContenidoRepository : IGenericRepository<TblCulturaTipoTablaContenido>
    {
        Task<long> Delete(string culture, int idtipotablacontenido);
        Task<TblCulturaTipoTablaContenido> Get(string culture, int idtipotablacontenido);
    }
}
