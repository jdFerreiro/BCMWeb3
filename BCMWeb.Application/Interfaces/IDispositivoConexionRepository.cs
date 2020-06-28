using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoConexionRepository : IGenericRepository<DeviceConnection>
    {
        Task<long> Delete(long idempresa, long iddispositivo, long idusuario, DateTime fechaconexion);
        Task<DeviceConnection> Get(long idempresa, long iddispositivo, long idusuario, DateTime fechaconexion);
    }
}
