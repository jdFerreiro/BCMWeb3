using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoPersonaClaveRepository : IGenericRepository<TblDocumentoPersonaClave>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idpersona);
        Task<TblDocumentoPersonaClave> Get(long idempresa, long iddocumento, long idtipodocumento, long idpersona);
    }
}
