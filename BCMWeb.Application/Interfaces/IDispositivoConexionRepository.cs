using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoConexionRepository : IGenericRepository<TblDispositivoConexion>
    {
        Task<long> Delete(long idempresa, long iddispositivo, long idusuario, DateTime fechaconexion);
        Task<TblDispositivoConexion> Get(long idempresa, long iddispositivo, long idusuario, DateTime fechaconexion);
    }
}
