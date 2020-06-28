using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICargoRepository : IGenericRepository<Position>
    {
        Task<long> Delete(long idempresa, long idcargo);
        Task<Position> Get(long idempresa, long idcargo);
    }
}
