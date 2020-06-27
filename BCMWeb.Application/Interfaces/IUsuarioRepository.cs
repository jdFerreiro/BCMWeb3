using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<User>
    {
        Task<long> Login(string codigo, string password);
        Task<long> LogOut(long id);
        Task<long> Lock(long id);

    }
}
