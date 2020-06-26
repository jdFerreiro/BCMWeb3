using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IVicepresidenciaRepository : IGenericRepository<Vicepresidencia>
    {
        Task<long> Delete(long idempresa, long idvicepresidencia);
        Task<Vicepresidencia> Get(long idempresa, long idvicepresidencia);
    }
}
