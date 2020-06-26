using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICulture_TipoIncidenteRepository : IGenericRepository<Culture_TipoIncidente>
    {
        Task<long> Delete(string culture, int idtipoincidente);
        Task<Culture_TipoIncidente> Get(string culture, int idtipoincidente);
    }
}
