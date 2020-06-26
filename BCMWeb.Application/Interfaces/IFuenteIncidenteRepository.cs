using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IFuenteIncidenteRepository : IGenericRepository<FuenteIncidente>
    {
        Task<long> Delete(int idfuenteincidente);
        Task<FuenteIncidente> Get(int idfuenteincidente);
    }
}
