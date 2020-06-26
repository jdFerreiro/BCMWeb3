using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoConexion1Repository : IGenericRepository<DispositivoConexion1>
    {
        Task<long> Delete(long iddispositivo, long idusuario, DateTime fechaconexion);
        Task<DispositivoConexion1> Get(long iddispositivo, long idusuario, DateTime fechaconexion);
    }
}
