using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoDireccionRepository : IGenericRepository<TblCulturaTipoDireccion>
    {
        Task<long> Delete(string culture, long idtipodireccion);
        Task<TblCulturaTipoDireccion> Get(string culture, long idtipodireccion);
    }
}
