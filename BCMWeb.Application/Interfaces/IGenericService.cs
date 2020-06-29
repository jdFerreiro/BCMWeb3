using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<T> Get(object[] keyValues);
        IEnumerable<T> GetAll();
        Task<long> Add(T entity);
        Task Delete(long id);
        Task<bool> Update(T entity);
    }
}
