using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoEscalaRepository : IGenericRepository<TblTipoEscala>
    {
        Task<long> Delete(long idempresa, long idtipoescala);
        Task<TblTipoEscala> Get(long idempresa, long idtipoescala);
    }
}
