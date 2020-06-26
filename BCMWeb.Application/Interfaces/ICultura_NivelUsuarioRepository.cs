using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_NivelUsuarioRepository : IGenericRepository<Cultura_NivelUsuario>
    {
        Task<long> Delete(string culture, long idnivelusuario);
        Task<Cultura_NivelUsuario> Get(string culture, long idnivelusuario);
    }
}
