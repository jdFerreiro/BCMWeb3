using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEstadoUsuarioRepository : IGenericRepository<EstadoUsuario>
    {
        Task<long> Delete(short idestadousuario);
        Task<EstadoUsuario> Get(short idestadousuario);
    }
}
