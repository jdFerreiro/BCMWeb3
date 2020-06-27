using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEmpresaUsuarioRepository : IGenericRepository<TblEmpresaUsuario>
    {
        Task<long> Delete(long idempresa, long idusuario);
        Task<TblEmpresaUsuario> Get(long idempresa, long idusuario);
    }
}
