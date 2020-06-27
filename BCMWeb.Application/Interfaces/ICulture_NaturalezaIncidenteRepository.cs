using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICulture_NaturalezaIncidenteRepository : IGenericRepository<TblCultureNaturalezaIncidente>
    {
        Task<long> Delete(string culture, int idnaturalezaincidente);
        Task<TblCultureNaturalezaIncidente> Get(string culture, int idnaturalezaincidente);
    }
}
