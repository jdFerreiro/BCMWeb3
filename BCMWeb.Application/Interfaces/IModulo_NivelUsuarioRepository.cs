using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IModulo_NivelUsuarioRepository : IGenericRepository<Modulo_NivelUsuario>
    {
        Task<long> Delete(long idempresa, long idnivelusuario, long idmodulo);
        Task<Modulo_NivelUsuario> Get(long idempresa, long idnivelusuario, long idmodulo);
    }
}
