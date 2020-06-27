using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoUsuarioRepository : IGenericRepository<TblCulturaEstadoUsuario>
    {
        Task<long> Delete(string culture, short idestadousuario);
        Task<TblCulturaEstadoUsuario> Get(string culture, short idestadousuario);
    }
}
