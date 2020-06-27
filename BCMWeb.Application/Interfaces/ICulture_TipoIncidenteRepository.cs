using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICulture_TipoIncidenteRepository : IGenericRepository<TblCultureTipoIncidente>
    {
        Task<long> Delete(string culture, int idtipoincidente);
        Task<TblCultureTipoIncidente> Get(string culture, int idtipoincidente);
    }
}
