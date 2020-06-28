using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIncidentesRepository : IGenericRepository<Incident>
    {
        Task<long> Delete(long idempresa, long idincidente);
        Task<Incident> Get(long idempresa, long idincidente);
    }
}
