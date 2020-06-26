using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface INaturalezaIncidenteRepository : IGenericRepository<NaturalezaIncidente>
    {
        Task<long> Delete(int idnaturalezaincidente);
        Task<NaturalezaIncidente> Get(int idnaturalezaincidente);
    }
}
