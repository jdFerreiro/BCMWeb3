using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoImpactoRepository : IGenericRepository<TblTipoImpacto>
    {
        Task<long> Delete(int idtipoimpacto);
        Task<TblTipoImpacto> Get(int idtipoimpacto);
    }
}
