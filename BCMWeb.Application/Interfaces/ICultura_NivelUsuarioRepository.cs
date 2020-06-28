using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_NivelUsuarioRepository : IGenericRepository<CultureLevelUser>
    {
        Task<long> Delete(string culture, long idnivelusuario);
        Task<CultureLevelUser> Get(string culture, long idnivelusuario);
    }
}
