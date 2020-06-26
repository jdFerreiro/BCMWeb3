using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IControlRiesgoRepository : IGenericRepository<ControlRiesgo>
    {
        Task<long> Delete(long idempresa, short idcontrol);
        Task<ControlRiesgo> Get(long idempresa, short idcontrol);
    }
}
