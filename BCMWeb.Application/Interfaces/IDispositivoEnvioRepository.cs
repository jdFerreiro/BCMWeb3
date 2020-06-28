using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoEnvioRepository : IGenericRepository<DeviceConsignment>
    {
        Task<long> Delete(long iddispositivo, long idsubmodulo);
        Task<DeviceConsignment> Get(long iddispositivo, long idsubmodulo);
    }
}
