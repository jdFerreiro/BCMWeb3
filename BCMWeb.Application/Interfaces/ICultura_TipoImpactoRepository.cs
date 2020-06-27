using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoImpactoRepository : IGenericRepository<TblCulturaTipoImpacto>
    {
        Task<long> Delete(string culture, int idtipoimpacto);
        Task<TblCulturaTipoImpacto> Get(string culture, int idtipoimpacto);
    }
}
