using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICulture_NaturalezaIncidenteRepository : IGenericRepository<Culture_NaturalezaIncidente>
    {
        Task<long> Delete(string culture, int idnaturalezaincidente);
        Task<Culture_NaturalezaIncidente> Get(string culture, int idnaturalezaincidente);
    }
}
