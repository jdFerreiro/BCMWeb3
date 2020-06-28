using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICulture_FuenteIncidenteRepository : IGenericRepository<IncidentSourceCulture>
    {
        Task<long> Delete(string culture, int idfuenteincidente);
        Task<IncidentSourceCulture> Get(string culture, int idfuenteincidente);
    }
}
