using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_NivelUsuarioRepository : IGenericRepository<TblCulturaNivelUsuario>
    {
        Task<long> Delete(string culture, long idnivelusuario);
        Task<TblCulturaNivelUsuario> Get(string culture, long idnivelusuario);
    }
}
