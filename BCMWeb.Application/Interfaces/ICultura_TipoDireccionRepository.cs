using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoDireccionRepository : IGenericRepository<AddressTypeCulture>
    {
        Task<long> Delete(string culture, long idtipodireccion);
        Task<AddressTypeCulture> Get(string culture, long idtipodireccion);
    }
}
