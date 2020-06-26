using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoIncidenteRepository : IGenericRepository<TipoIncidente>
    {
        Task<long> Delete(int idtipoincidente);
        Task<TipoIncidente> Get(int idtipoincidente);
    }
}
