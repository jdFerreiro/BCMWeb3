using BCMWeb.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task<T> Get(object[] keyValues);
        Task Add(T entity);
        Task Delete(object[] keyValues);
        void Update(T entity);
    }
}
