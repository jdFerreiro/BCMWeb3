using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoTelefonoRepository : IGenericRepository<TblCulturaTipoTelefono>
    {
        Task<long> Delete(string culture, long idtipotelefono);
        Task<TblCulturaTipoTelefono> Get(string culture, long idtipotelefono);
    }
}
