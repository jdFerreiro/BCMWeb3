using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUnidadOrganizativaRepository : IGenericRepository<UnidadOrganizativa>
    {
        Task<long> Delete(long idempresa, long idunidadorganizativa);
        Task<UnidadOrganizativa> Get(long idempresa, long idunidadorganizativa);
    }
}
