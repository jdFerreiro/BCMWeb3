using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoTelefonoRepository : IGenericRepository<PhoneTypeCulture>
    {
        Task<long> Delete(string culture, long idtipotelefono);
        Task<PhoneTypeCulture> Get(string culture, long idtipotelefono);
    }
}
