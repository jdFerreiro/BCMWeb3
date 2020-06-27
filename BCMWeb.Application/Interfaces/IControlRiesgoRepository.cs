using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IControlRiesgoRepository : IGenericRepository<TblControlRiesgo>
    {
        Task<long> Delete(long idempresa, short idcontrol);
        Task<TblControlRiesgo> Get(long idempresa, short idcontrol);
    }
}
