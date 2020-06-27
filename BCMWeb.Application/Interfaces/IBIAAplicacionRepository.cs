using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAAplicacionRepository : IGenericRepository<TblBiaaplicacion>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idaplicacion);
        Task<TblBiaaplicacion> Get(long idempresa, long iddocumentobia, long idproceso, long idaplicacion);
    }
}
