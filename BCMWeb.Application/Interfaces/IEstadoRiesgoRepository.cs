using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEstadoRiesgoRepository : IGenericRepository<TblEstadoRiesgo>
    {
        Task<long> Delete(long idempresa, short idestadoriesgo);
        Task<TblEstadoRiesgo> Get(long idempresa, short idestadoriesgo);
    }
}
