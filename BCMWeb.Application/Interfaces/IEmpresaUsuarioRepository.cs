using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEmpresaUsuarioRepository : IGenericRepository<EmpresaUsuario>
    {
        Task<long> Delete(long idempresa, long idusuario);
        Task<EmpresaUsuario> Get(long idempresa, long idusuario);
    }
}
