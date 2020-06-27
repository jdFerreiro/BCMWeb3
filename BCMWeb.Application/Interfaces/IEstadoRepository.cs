using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEstadoRepository : IGenericRepository<TblEstado>
    {
        Task<long> Delete(long idpais, long idestado);
        Task<TblEstado> Get(long idpais, long idestado);
    }
}
