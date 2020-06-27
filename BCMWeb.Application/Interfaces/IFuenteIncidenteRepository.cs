using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IFuenteIncidenteRepository : IGenericRepository<TblFuenteIncidente>
    {
        Task<long> Delete(int idfuenteincidente);
        Task<TblFuenteIncidente> Get(int idfuenteincidente);
    }
}
