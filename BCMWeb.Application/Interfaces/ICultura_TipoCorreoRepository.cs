using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoCorreoRepository : IGenericRepository<TblCulturaTipoCorreo>
    {
        Task<long> Delete(string culture, long idtipocorreo);
        Task<TblCulturaTipoCorreo> Get(string culture, long idtipocorreo);
    }
}
