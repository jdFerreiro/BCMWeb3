using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PBEPruebaEstatusRepository : IGenericRepository<TblCulturaPbepruebaEstatus>
    {
        Task<long> Delete(string cultura, short idestatus);
        Task<TblCulturaPbepruebaEstatus> Get(string cultura, short idestatus);
    }
}
