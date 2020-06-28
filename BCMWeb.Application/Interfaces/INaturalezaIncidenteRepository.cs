using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface INaturalezaIncidenteRepository : IGenericRepository<OriginIncident>
    {
        Task<long> Delete(int idnaturalezaincidente);
        Task<OriginIncident> Get(int idnaturalezaincidente);
    }
}
