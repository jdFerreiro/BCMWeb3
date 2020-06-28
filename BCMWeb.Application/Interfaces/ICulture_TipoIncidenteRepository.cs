using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICulture_TipoIncidenteRepository : IGenericRepository<IncidentTypeCulture>
    {
        Task<long> Delete(string culture, int idtipoincidente);
        Task<IncidentTypeCulture> Get(string culture, int idtipoincidente);
    }
}
