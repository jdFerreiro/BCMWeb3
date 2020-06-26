using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICargoRepository : IGenericRepository<Cargo>
    {
        Task<long> Delete(long idempresa, long idcargo);
        Task<Cargo> Get(long idempresa, long idcargo);
    }
}
