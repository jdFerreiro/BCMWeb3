using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoAnexoRepository : IGenericRepository<TblDocumentoAnexo>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idanexo);
        Task<TblDocumentoAnexo> Get(long idempresa, long iddocumento, long idtipodocumento, long idanexo);
    }
}
