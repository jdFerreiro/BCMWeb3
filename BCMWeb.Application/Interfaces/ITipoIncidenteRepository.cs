using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoIncidenteRepository : IGenericRepository<TblTipoIncidente>
    {
        Task<long> Delete(int idtipoincidente);
        Task<TblTipoIncidente> Get(int idtipoincidente);
    }
}
