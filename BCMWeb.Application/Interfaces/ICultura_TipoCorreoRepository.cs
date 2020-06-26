using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoCorreoRepository : IGenericRepository<Cultura_TipoCorreo>
    {
        Task<long> Delete(string culture, long idtipocorreo);
        Task<Cultura_TipoCorreo> Get(string culture, long idtipocorreo);
    }
}
