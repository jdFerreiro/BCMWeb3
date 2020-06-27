using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEstadoUsuarioRepository : IGenericRepository<TblEstadoUsuario>
    {
        Task<long> Delete(short idestadousuario);
        Task<TblEstadoUsuario> Get(short idestadousuario);
    }
}
