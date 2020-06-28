using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoConexion1Repository : IGenericRepository<DeviceConnection>
    {
        Task<long> Delete(long iddispositivo, long idusuario, DateTime fechaconexion);
        Task<DeviceConnection> Get(long iddispositivo, long idusuario, DateTime fechaconexion);
    }
}
