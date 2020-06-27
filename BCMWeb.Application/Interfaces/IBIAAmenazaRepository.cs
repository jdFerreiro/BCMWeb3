using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAAmenazaRepository : IGenericRepository<TblBiaamenaza>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idproceso, long idamenaza);
        Task<TblBiaamenaza> Get(long idempresa, long iddocumento, long idproceso, long idamenaza);
    }
}
