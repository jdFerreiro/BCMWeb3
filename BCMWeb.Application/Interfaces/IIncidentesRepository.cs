using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIncidentesRepository : IGenericRepository<TblIncidentes>
    {
        Task<long> Delete(long idempresa, long idincidente);
        Task<TblIncidentes> Get(long idempresa, long idincidente);
    }
}
