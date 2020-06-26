using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoConexionRepository : IGenericRepository<DispositivoConexion>
    {
        Task<long> Delete(long idempresa, long iddispositivo, long idusuario, DateTime fechaconexion);
        Task<DispositivoConexion> Get(long idempresa, long iddispositivo, long idusuario, DateTime fechaconexion);
    }
}
