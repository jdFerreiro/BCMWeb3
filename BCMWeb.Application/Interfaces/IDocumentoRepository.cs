using BCMWeb.Core.Entities;
using System.Threading.Tasks;


namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoRepository : IGenericRepository<TblDocumento>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento);
        Task<TblDocumento> Get(long idempresa, long iddocumento, long idtipodocumento);
    }
}
