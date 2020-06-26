using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoUsuarioRepository : IGenericRepository<Cultura_EstadoUsuario>
    {
        Task<long> Delete(string culture, short idestadousuario);
        Task<Cultura_EstadoUsuario> Get(string culture, short idestadousuario);
    }
}
