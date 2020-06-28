using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEscalaRepository : IGenericRepository<Scale>
    {
        Task<long> Delete(long idempresa, long idescala);
        Task<Scale> Get(long idempresa, long idescala);
    }
}
