using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.Entities;
using BCMWeb.Core.QueryFilters;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICompanyService
    {
        Task<Company> Get(object[] keyValues);
        PagedList<Company> GetAll(CompanyQueryFilter filters);
        Task<long> Add(Company entity);
        Task<bool> Delete(long id);
        Task<bool> Update(Company entity);

    }
}
