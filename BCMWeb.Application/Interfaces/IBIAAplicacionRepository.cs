using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAAplicacionRepository : IGenericRepository<BIAAplicacion>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idaplicacion);
        Task<BIAAplicacion> Get(long idempresa, long iddocumentobia, long idproceso, long idaplicacion);
    }
}
