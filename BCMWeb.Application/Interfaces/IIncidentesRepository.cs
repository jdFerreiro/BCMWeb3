using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIncidentesRepository : IGenericRepository<Incidentes>
    {
        Task<long> Delete(long idempresa, long idincidente);
        Task<Incidentes> Get(long idempresa, long idincidente);
    }
}
