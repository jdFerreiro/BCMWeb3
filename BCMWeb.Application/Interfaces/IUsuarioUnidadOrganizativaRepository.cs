using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUsuarioUnidadOrganizativaRepository : IGenericRepository<UserOrganizationUnit>
    {
        Task<long> Delete(long idempresa, long idunidadorganizativa, long idusuario);
        Task<UserOrganizationUnit> Get(long idempresa, long idunidadorganizativa, long idusuario);
    }
}
