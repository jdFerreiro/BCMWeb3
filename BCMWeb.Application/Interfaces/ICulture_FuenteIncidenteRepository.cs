using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICulture_FuenteIncidenteRepository : IGenericRepository<Culture_FuenteIncidente>
    {
        Task<long> Delete(string culture, int idfuenteincidente);
        Task<Culture_FuenteIncidente> Get(string culture, int idfuenteincidente);
    }
}
