using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEstadoRepository : IGenericRepository<Estado>
    {
        Task<long> Delete(long idpais, long idestado);
        Task<Estado> Get(long idpais, long idestado);
    }
}
