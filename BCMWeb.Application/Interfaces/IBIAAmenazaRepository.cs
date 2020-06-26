using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAAmenazaRepository : IGenericRepository<BIAAmenaza>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idproceso, long idamenaza);
        Task<BIAAmenaza> Get(long idempresa, long iddocumento, long idproceso, long idamenaza);
    }
}
