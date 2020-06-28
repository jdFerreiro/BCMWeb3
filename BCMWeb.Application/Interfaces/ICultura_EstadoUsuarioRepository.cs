using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoUsuarioRepository : IGenericRepository<UserSateCulture>
    {
        Task<long> Delete(string culture, short idestadousuario);
        Task<UserSateCulture> Get(string culture, short idestadousuario);
    }
}
