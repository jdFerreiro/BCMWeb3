using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICulture_FuenteIncidenteRepository : IGenericRepository<TblCultureFuenteIncidente>
    {
        Task<long> Delete(string culture, int idfuenteincidente);
        Task<TblCultureFuenteIncidente> Get(string culture, int idfuenteincidente);
    }
}
