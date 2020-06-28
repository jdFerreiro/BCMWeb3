using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUnidadOrganizativaRepository : IGenericRepository<OrganizationUnit>
    {
        Task<long> Delete(long idempresa, long idunidadorganizativa);
        Task<OrganizationUnit> Get(long idempresa, long idunidadorganizativa);
    }
}
