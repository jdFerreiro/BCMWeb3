using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICulture_NaturalezaIncidenteRepository : IGenericRepository<OriginIncidentCulture>
    {
        Task<long> Delete(string culture, int idnaturalezaincidente);
        Task<OriginIncidentCulture> Get(string culture, int idnaturalezaincidente);
    }
}
