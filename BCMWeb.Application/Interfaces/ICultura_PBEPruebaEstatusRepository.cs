using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PBEPruebaEstatusRepository : IGenericRepository<Cultura_PBEPruebaEstatus>
    {
        Task<long> Delete(string cultura, short idestatus);
        Task<Cultura_PBEPruebaEstatus> Get(string cultura, short idestatus);
    }
}
