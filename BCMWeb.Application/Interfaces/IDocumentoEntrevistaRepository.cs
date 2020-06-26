using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoEntrevistaRepository : IGenericRepository<DocumentoEntrevista>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long identrevista);
        Task<DocumentoEntrevista> Get(long idempresa, long iddocumento, long idtipodocumento, long identrevista);
    }
}
