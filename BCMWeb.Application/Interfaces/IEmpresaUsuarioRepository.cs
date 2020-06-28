using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEmpresaUsuarioRepository : IGenericRepository<UserCompany>
    {
        Task<long> Delete(long idempresa, long idusuario);
        Task<UserCompany> Get(long idempresa, long idusuario);
    }
}
