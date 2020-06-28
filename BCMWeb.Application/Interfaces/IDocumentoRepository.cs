using BCMWeb.Core.Entities;
using System.Threading.Tasks;


namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoRepository : IGenericRepository<Document>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento);
        Task<Document> Get(long idempresa, long iddocumento, long idtipodocumento);
    }
}
