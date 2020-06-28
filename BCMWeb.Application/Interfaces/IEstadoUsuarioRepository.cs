using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEstadoUsuarioRepository : IGenericRepository<UserState>
    {
        Task<long> Delete(short idestadousuario);
        Task<UserState> Get(short idestadousuario);
    }
}
