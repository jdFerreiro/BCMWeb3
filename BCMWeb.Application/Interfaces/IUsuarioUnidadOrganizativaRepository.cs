using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUsuarioUnidadOrganizativaRepository : IGenericRepository<UsuarioUnidadOrganizativa>
    {
        Task<long> Delete(long idempresa, long idunidadorganizativa, long idusuario);
        Task<UsuarioUnidadOrganizativa> Get(long idempresa, long idunidadorganizativa, long idusuario);
    }
}
