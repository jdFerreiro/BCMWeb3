using BCMWeb.Core.Entities;
using System.Threading.Tasks;


namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoRepository : IGenericRepository<Documento>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento);
        Task<Documento> Get(long idempresa, long iddocumento, long idtipodocumento);
    }
}
