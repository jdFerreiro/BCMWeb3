using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface INivelImpactoRepository : IGenericRepository<TblNivelImpacto>
    {
        Task<long> Delete(int idnivelimpacto);
        Task<TblNivelImpacto> Get(int idnivelimpacto);
    }
}
