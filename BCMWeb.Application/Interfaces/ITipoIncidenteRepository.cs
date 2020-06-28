using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoIncidenteRepository : IGenericRepository<IncidentType>
    {
        Task<long> Delete(int idtipoincidente);
        Task<IncidentType> Get(int idtipoincidente);
    }
}
