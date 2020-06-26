using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IModulo_UsuarioRepository : IGenericRepository<Modulo_Usuario>
    {
        Task<long> Delete(long idempresa, long idmodulo, long idusuario);
        Task<Modulo_Usuario> Get(long idempresa, long idmodulo, long idusuario);
    }
}
