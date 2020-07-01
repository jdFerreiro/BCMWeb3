using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.Entities;
using BCMWeb.Core.QueryFilters;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUserService
    {
        Task<User> Get(object[] keyValues);
        PagedList<User> GetAll(PaginationFilter filters);
        Task<long> Add(User entity);
        Task<bool> Delete(long id);
        Task<bool> Update(User entity);
        User Login(UserLogin userLogin);
    }
}
