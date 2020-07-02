using BCMWeb.Core.CustomEntities;
using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> Login(UserLogin login);
        Task<long> LogOut(long id);
        Task<long> Lock(long id);

    }
}
