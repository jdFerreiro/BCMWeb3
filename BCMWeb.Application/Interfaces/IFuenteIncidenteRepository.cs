using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IFuenteIncidenteRepository : IGenericRepository<IncidentSource>
    {
        Task<long> Delete(int idfuenteincidente);
        Task<IncidentSource> Get(int idfuenteincidente);
    }
}
