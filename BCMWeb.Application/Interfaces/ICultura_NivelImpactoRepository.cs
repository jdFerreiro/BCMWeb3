using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_NivelImpactoRepository : IGenericRepository<TblCulturaNivelImpacto>
    {
        Task<long> Delete(string culture, int idnivelimpacto);
        Task<TblCulturaNivelImpacto> Get(string culture, int idnivelimpacto);
    }
}
