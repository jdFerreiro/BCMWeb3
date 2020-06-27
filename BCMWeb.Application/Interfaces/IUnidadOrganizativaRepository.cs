using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUnidadOrganizativaRepository : IGenericRepository<TblUnidadOrganizativa>
    {
        Task<long> Delete(long idempresa, long idunidadorganizativa);
        Task<TblUnidadOrganizativa> Get(long idempresa, long idunidadorganizativa);
    }
}
