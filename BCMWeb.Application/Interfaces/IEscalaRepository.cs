using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEscalaRepository : IGenericRepository<TblEscala>
    {
        Task<long> Delete(long idempresa, long idescala);
        Task<TblEscala> Get(long idempresa, long idescala);
    }
}
