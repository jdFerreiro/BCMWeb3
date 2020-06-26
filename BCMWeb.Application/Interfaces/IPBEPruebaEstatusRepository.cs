using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEstatusRepository : IGenericRepository<PBEPruebaEstatus>
    {
        Task<long> Delete(short idestatus);
        Task<PBEPruebaEstatus> Get(short idestatus);
    }
}
