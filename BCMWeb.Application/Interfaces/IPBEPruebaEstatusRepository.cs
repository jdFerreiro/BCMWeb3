using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEstatusRepository : IGenericRepository<PPETestStatus>
    {
        Task<long> Delete(short idestatus);
        Task<PPETestStatus> Get(short idestatus);
    }
}
