using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoEnvio1Repository : IGenericRepository<DeviceConsignment>
    {
        Task<long> Delete(long iddispositivo, long idusuario, long idempresa, long idsubmodulo, long idusuarioenvia, DateTime fechaenvio);
        Task<DeviceConsignment> Get(long iddispositivo, long idusuario, long idempresa, long idsubmodulo, long idusuarioenvia, DateTime fechaenvio);
    }
}
