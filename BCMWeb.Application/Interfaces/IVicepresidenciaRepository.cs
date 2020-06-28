using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IVicepresidenciaRepository : IGenericRepository<VicePresidency>
    {
        Task<long> Delete(long idempresa, long idvicepresidencia);
        Task<VicePresidency> Get(long idempresa, long idvicepresidencia);
    }
}
