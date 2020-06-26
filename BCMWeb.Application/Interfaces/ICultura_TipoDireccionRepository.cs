using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoDireccionRepository : IGenericRepository<Cultura_TipoDireccion>
    {
        Task<long> Delete(string culture, long idtipodireccion);
        Task<Cultura_TipoDireccion> Get(string culture, long idtipodireccion);
    }
}
