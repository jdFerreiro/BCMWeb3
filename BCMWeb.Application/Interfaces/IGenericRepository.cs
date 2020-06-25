using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(long id);
        Task<IEnumerable<T>> GetAll();
        Task<long> Add(T entity);
        Task<long> Delete(long id);
        Task<long> Update(T entity);
    }
}
