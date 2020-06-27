using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoEnvio1Repository : IGenericRepository<TblDispositivoEnvio1>
    {
        Task<long> Delete(long iddispositivo, long idusuario, long idempresa, long idsubmodulo, long idusuarioenvia, DateTime fechaenvio);
        Task<TblDispositivoEnvio1> Get(long iddispositivo, long idusuario, long idempresa, long idsubmodulo, long idusuarioenvia, DateTime fechaenvio);
    }
}
