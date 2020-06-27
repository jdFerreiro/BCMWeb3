using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface INaturalezaIncidenteRepository : IGenericRepository<TblNaturalezaIncidente>
    {
        Task<long> Delete(int idnaturalezaincidente);
        Task<TblNaturalezaIncidente> Get(int idnaturalezaincidente);
    }
}
