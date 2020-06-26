using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoEnvioRepository : IGenericRepository<DispositivoEnvio>
    {
        Task<long> Delete(long iddispositivo, long idsubmodulo);
        Task<DispositivoEnvio> Get(long iddispositivo, long idsubmodulo);
    }
}
