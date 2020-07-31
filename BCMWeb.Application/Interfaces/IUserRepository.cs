using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> Login(UserLogin login);
        Task<bool> LogOut(long id);
        Task<bool> Lock(long id);
        Task<bool> Delete(long id);

    }
}
