using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoConexion1Repository : IGenericRepository<TblDispositivoConexion1>
    {
        Task<long> Delete(long iddispositivo, long idusuario, DateTime fechaconexion);
        Task<TblDispositivoConexion1> Get(long iddispositivo, long idusuario, DateTime fechaconexion);
    }
}
