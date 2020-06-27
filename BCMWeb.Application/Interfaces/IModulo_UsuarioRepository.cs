using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IModulo_UsuarioRepository : IGenericRepository<TblModuloUsuario>
    {
        Task<long> Delete(long idempresa, long idmodulo, long idusuario);
        Task<TblModuloUsuario> Get(long idempresa, long idmodulo, long idusuario);
    }
}
