using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoTelefonoRepository : IGenericRepository<Cultura_TipoTelefono>
    {
        Task<long> Delete(string culture, long idtipotelefono);
        Task<Cultura_TipoTelefono> Get(string culture, long idtipotelefono);
    }
}
