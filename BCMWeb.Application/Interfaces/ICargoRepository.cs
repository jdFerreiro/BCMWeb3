using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICargoRepository : IGenericRepository<TblCargo>
    {
        Task<long> Delete(long idempresa, long idcargo);
        Task<TblCargo> Get(long idempresa, long idcargo);
    }
}
