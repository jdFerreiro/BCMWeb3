using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEscalaRepository : IGenericRepository<Escala>
    {
        Task<long> Delete(long idempresa, long idescala);
        Task<Escala> Get(long idempresa, long idescala);
    }
}
