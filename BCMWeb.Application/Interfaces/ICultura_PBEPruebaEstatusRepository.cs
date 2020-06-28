using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PBEPruebaEstatusRepository : IGenericRepository<PPETestStatusCulture>
    {
        Task<long> Delete(string cultura, short idestatus);
        Task<PPETestStatusCulture> Get(string cultura, short idestatus);
    }
}
