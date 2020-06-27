using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IVicepresidenciaRepository : IGenericRepository<TblVicepresidencia>
    {
        Task<long> Delete(long idempresa, long idvicepresidencia);
        Task<TblVicepresidencia> Get(long idempresa, long idvicepresidencia);
    }
}
