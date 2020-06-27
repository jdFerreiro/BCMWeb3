using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDispositivoEnvioRepository : IGenericRepository<TblDispositivoEnvio>
    {
        Task<long> Delete(long iddispositivo, long idsubmodulo);
        Task<TblDispositivoEnvio> Get(long iddispositivo, long idsubmodulo);
    }
}
