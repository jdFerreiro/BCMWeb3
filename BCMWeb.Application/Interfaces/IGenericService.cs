using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.QueryFilters;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<T> Get(object[] keyValues);
        PagedList<T> GetAll(PaginationFilter filters);
        Task<long> Add(T entity);
        Task<bool> Delete(long id);
        Task<bool> Update(T entity);
    }
}
