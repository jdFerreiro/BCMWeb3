using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IModulo_NivelUsuarioRepository : IGenericRepository<MenuLevelUser>
    {
        Task<long> Delete(long idempresa, long idnivelusuario, long idmodulo);
        Task<MenuLevelUser> Get(long idempresa, long idnivelusuario, long idmodulo);
    }
}
