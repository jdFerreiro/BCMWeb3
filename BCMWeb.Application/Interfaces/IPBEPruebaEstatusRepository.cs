using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEstatusRepository : IGenericRepository<TblPbepruebaEstatus>
    {
        Task<long> Delete(short idestatus);
        Task<TblPbepruebaEstatus> Get(short idestatus);
    }
}
